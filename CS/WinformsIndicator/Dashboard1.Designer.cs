namespace WinForm {
    partial class Dashboard1 {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.CalculatedField calculatedField1 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField2 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField3 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField4 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DashboardCommon.CalculatedField calculatedField5 = new DevExpress.DashboardCommon.CalculatedField();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.AllColumns allColumns1 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.AllColumns allColumns2 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.AllColumns allColumns3 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.AllColumns allColumns4 = new DevExpress.DataAccess.Sql.AllColumns();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join3 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo3 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard1));
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
            this.dashboardSqlDataSource1 = new DevExpress.DashboardCommon.DashboardSqlDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // chartDashboardItem1
            // 
            dimension1.DataMember = "OrderDate";
            dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month;
            this.chartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.chartDashboardItem1.AxisX.TitleVisible = false;
            this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
            this.chartDashboardItem1.CustomProperties.SetValue("Val", "5000", true);
            measure1.DataMember = "UnitPrice";
            this.chartDashboardItem1.DataItemRepository.Clear();
            this.chartDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.chartDashboardItem1.DataItemRepository.Add(measure1, "DataItem1");
            this.chartDashboardItem1.DataMember = "Orders";
            this.chartDashboardItem1.DataSource = this.dashboardSqlDataSource1;
            this.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartDashboardItem1.InteractivityOptions.IsDrillDownEnabled = true;
            this.chartDashboardItem1.Name = "Sales by Month";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line;
            simpleSeries1.AddDataItem("Value", measure1);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartDashboardItem1.ShowCaption = true;
            // 
            // dashboardSqlDataSource1
            // 
            calculatedField1.DataMember = "Orders";
            calculatedField1.Expression = "[UnitPrice]*1.12";
            calculatedField1.Name = "Fake";
            calculatedField2.DataMember = "Orders";
            calculatedField2.Expression = "[Fake]/1.08";
            calculatedField2.Name = "Low";
            calculatedField3.DataMember = "Orders";
            calculatedField3.Expression = "[Fake]*1.1";
            calculatedField3.Name = "High";
            calculatedField4.DataMember = "Orders";
            calculatedField4.Expression = "[Fake]/1.05";
            calculatedField4.Name = "Open";
            calculatedField5.DataMember = "Orders";
            calculatedField5.Expression = "[Fake]*1.05";
            calculatedField5.Name = "Close";
            this.dashboardSqlDataSource1.CalculatedFields.AddRange(new DevExpress.DashboardCommon.CalculatedField[] {
            calculatedField1,
            calculatedField2,
            calculatedField3,
            calculatedField4,
            calculatedField5});
            this.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1";
            this.dashboardSqlDataSource1.ConnectionName = "nwind";
            this.dashboardSqlDataSource1.Name = "SQL Data Source 1";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"347\" />";
            table1.Name = "Orders";
            allColumns1.Table = table1;
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"167\" />";
            table2.Name = "OrderDetails";
            allColumns2.Table = table2;
            table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"287\" />";
            table3.Name = "Products";
            allColumns3.Table = table3;
            table4.MetaSerializable = "<Meta X=\"495\" Y=\"30\" Width=\"125\" Height=\"467\" />";
            table4.Name = "Employees";
            allColumns4.Table = table4;
            selectQuery1.Columns.Add(allColumns1);
            selectQuery1.Columns.Add(allColumns2);
            selectQuery1.Columns.Add(allColumns3);
            selectQuery1.Columns.Add(allColumns4);
            selectQuery1.Name = "Orders";
            relationColumnInfo1.NestedKeyColumn = "OrderID";
            relationColumnInfo1.ParentKeyColumn = "OrderID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            relationColumnInfo2.NestedKeyColumn = "ProductID";
            relationColumnInfo2.ParentKeyColumn = "ProductID";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table3;
            join2.Parent = table2;
            relationColumnInfo3.NestedKeyColumn = "EmployeeID";
            relationColumnInfo3.ParentKeyColumn = "EmployeeID";
            join3.KeyColumns.Add(relationColumnInfo3);
            join3.Nested = table4;
            join3.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Relations.Add(join3);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table3);
            selectQuery1.Tables.Add(table4);
            this.dashboardSqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable");
            // 
            // Dashboard1
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardSqlDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.chartDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.chartDashboardItem1;
            dashboardLayoutItem1.Weight = 50D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Weight = 100D;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Sales Overview";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardSqlDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
        private DevExpress.DashboardCommon.DashboardSqlDataSource dashboardSqlDataSource1;
    }
}
