using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DashboardCommon;
using DevExpress.DashboardCommon.ViewerData;

namespace WinForm {
    public partial class FormDesigner : Form {
        public FormDesigner() {
            try {
                IndicatorFactory.Register<MovingIndicator>("Moving average");
            } catch(Exception e) {
                MessageBox.Show(e.Message);
            }
            InitializeComponent();
            var dashboard = new Dashboard1();
            ChartDashboardItem chartItem = dashboard.Items.First(x => x.ComponentName == "chartDashboardItem1") as ChartDashboardItem;
            MovingIndicator trendLine = new MovingIndicator() {
                Name = "MovingLine1",
                Value = "DataItem1",
                ValueLevel = DevExpress.XtraCharts.ValueLevel.Value,
                Color = Color.Orange,
                LegendText = "Moving Average"
            };
            chartItem.Indicators.Add(trendLine);
            dashboardViewer.Dashboard = dashboard;
            dashboardViewer.CreateRibbon();
            dashboardViewer.CreateCustomItemBars();
        }
    }

    public class MovingIndicator : ChartCustomIndicator {
        protected override Dictionary<AxisPoint, object> Calculate(Dictionary<AxisPoint, decimal?> values) {
            var items = new Dictionary<AxisPoint, object>(values.Count);

            var sum = decimal.Zero;
            var count = 0;
            foreach(KeyValuePair<AxisPoint, decimal?> point in values) {
                if(count == 0) {
                    items.Add(point.Key, null);
                } else {
                    items.Add(point.Key, sum / count);
                }
                sum += point.Value ?? 0;
                count++;
            }

            return items;
        }
    }
}
