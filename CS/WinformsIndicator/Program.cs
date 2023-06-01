using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace WinForm {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Dashboard.CustomItemMetadataTypes.Register<SimpleTableMetadata>();

            Application.Run(new FormDesigner());
        }
    }

    [DisplayName("Simple Table"),
   CustomItemDescription("Simple Table description"),
   CustomItemImage("TutorialsCustomItems.Images.CustomGrid.svg")]
    class SimpleTableMetadata : CustomItemMetadata {
        [DisplayName("Measure"),
         EmptyDataItemPlaceholder("MeasureColumn"),]
        public Measure MeasureColumn {
            get { return GetPropertyValue<Measure>(); }
            set { SetPropertyValue(value); }
        }
        [DisplayName("Dimensions"),
        EmptyDataItemPlaceholder("DimensionColumn")]
        public DimensionCollection DimensionColumns { get; } = new DimensionCollection();
    }

    public class SimpleTableProvider : CustomControlProviderBase {
        GridView view;
        GridControl grid;
        protected override Control Control { get { return grid; } }
        public SimpleTableProvider() {
            grid = new GridControl();
            view = new GridView();
            view.OptionsView.ShowGroupPanel = false;
            view.CustomColumnDisplayText += View_CustomColumnDisplayText;
            grid.MainView = view;
        }
        protected override void UpdateControl(CustomItemData customItemData) {
            DashboardFlatDataSource flatData = customItemData.GetFlatData();
            grid.DataSource = flatData;
            view.PopulateColumns();
            view.BestFitColumns();
        }
        void View_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e) {
            DashboardFlatDataSource data = (DashboardFlatDataSource)grid.DataSource;
            e.DisplayText = data.GetDisplayText(e.Column.FieldName, e.ListSourceRowIndex);
        }

        protected override XRControl GetPrintableControl(CustomItemData customItemData, CustomItemExportInfo exportInfo) {
            PrintableComponentContainer container = new PrintableComponentContainer();
            container.PrintableComponent = grid;
            return container;
        }
    }
}
