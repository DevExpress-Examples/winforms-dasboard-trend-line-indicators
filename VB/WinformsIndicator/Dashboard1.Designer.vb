Namespace WinForm
	Partial Public Class Dashboard1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim calculatedField1 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField2 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField3 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField4 As New DevExpress.DashboardCommon.CalculatedField()
			Dim calculatedField5 As New DevExpress.DashboardCommon.CalculatedField()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim allColumns1 As New DevExpress.DataAccess.Sql.AllColumns()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim allColumns2 As New DevExpress.DataAccess.Sql.AllColumns()
			Dim table2 As New DevExpress.DataAccess.Sql.Table()
			Dim allColumns3 As New DevExpress.DataAccess.Sql.AllColumns()
			Dim table3 As New DevExpress.DataAccess.Sql.Table()
			Dim allColumns4 As New DevExpress.DataAccess.Sql.AllColumns()
			Dim table4 As New DevExpress.DataAccess.Sql.Table()
			Dim join1 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim join2 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo2 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim join3 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo3 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.dashboardSqlDataSource1 = New DevExpress.DashboardCommon.DashboardSqlDataSource()
			CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' chartDashboardItem1
			' 
			dimension1.DataMember = "OrderDate"
			dimension1.DateTimeGroupInterval = DevExpress.DashboardCommon.DateTimeGroupInterval.Month
			Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.chartDashboardItem1.AxisX.TitleVisible = False
			Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
			Me.chartDashboardItem1.CustomProperties.SetValue("Val", "5000", True)
			measure1.DataMember = "UnitPrice"
			Me.chartDashboardItem1.DataItemRepository.Clear()
			Me.chartDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
			Me.chartDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
			Me.chartDashboardItem1.DataMember = "Orders"
			Me.chartDashboardItem1.DataSource = Me.dashboardSqlDataSource1
			Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartDashboardItem1.InteractivityOptions.IsDrillDownEnabled = True
			Me.chartDashboardItem1.Name = "Sales by Month"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.TitleVisible = True
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.SeriesType = DevExpress.DashboardCommon.SimpleSeriesType.Line
			simpleSeries1.AddDataItem("Value", measure1)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartDashboardItem1.ShowCaption = True
			' 
			' dashboardSqlDataSource1
			' 
			calculatedField1.DataMember = "Orders"
			calculatedField1.Expression = "[UnitPrice]*1.12"
			calculatedField1.Name = "Fake"
			calculatedField2.DataMember = "Orders"
			calculatedField2.Expression = "[Fake]/1.08"
			calculatedField2.Name = "Low"
			calculatedField3.DataMember = "Orders"
			calculatedField3.Expression = "[Fake]*1.1"
			calculatedField3.Name = "High"
			calculatedField4.DataMember = "Orders"
			calculatedField4.Expression = "[Fake]/1.05"
			calculatedField4.Name = "Open"
			calculatedField5.DataMember = "Orders"
			calculatedField5.Expression = "[Fake]*1.05"
			calculatedField5.Name = "Close"
			Me.dashboardSqlDataSource1.CalculatedFields.AddRange(New DevExpress.DashboardCommon.CalculatedField() { calculatedField1, calculatedField2, calculatedField3, calculatedField4, calculatedField5})
			Me.dashboardSqlDataSource1.ComponentName = "dashboardSqlDataSource1"
			Me.dashboardSqlDataSource1.ConnectionName = "nwind"
			Me.dashboardSqlDataSource1.Name = "SQL Data Source 1"
			table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""347"" />"
			table1.Name = "Orders"
			allColumns1.Table = table1
			table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""167"" />"
			table2.Name = "OrderDetails"
			allColumns2.Table = table2
			table3.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""287"" />"
			table3.Name = "Products"
			allColumns3.Table = table3
			table4.MetaSerializable = "<Meta X=""495"" Y=""30"" Width=""125"" Height=""467"" />"
			table4.Name = "Employees"
			allColumns4.Table = table4
			selectQuery1.Columns.Add(allColumns1)
			selectQuery1.Columns.Add(allColumns2)
			selectQuery1.Columns.Add(allColumns3)
			selectQuery1.Columns.Add(allColumns4)
			selectQuery1.Name = "Orders"
			relationColumnInfo1.NestedKeyColumn = "OrderID"
			relationColumnInfo1.ParentKeyColumn = "OrderID"
			join1.KeyColumns.Add(relationColumnInfo1)
			join1.Nested = table2
			join1.Parent = table1
			relationColumnInfo2.NestedKeyColumn = "ProductID"
			relationColumnInfo2.ParentKeyColumn = "ProductID"
			join2.KeyColumns.Add(relationColumnInfo2)
			join2.Nested = table3
			join2.Parent = table2
			relationColumnInfo3.NestedKeyColumn = "EmployeeID"
			relationColumnInfo3.ParentKeyColumn = "EmployeeID"
			join3.KeyColumns.Add(relationColumnInfo3)
			join3.Nested = table4
			join3.Parent = table1
			selectQuery1.Relations.Add(join1)
			selectQuery1.Relations.Add(join2)
			selectQuery1.Relations.Add(join3)
			selectQuery1.Tables.Add(table1)
			selectQuery1.Tables.Add(table2)
			selectQuery1.Tables.Add(table3)
			selectQuery1.Tables.Add(table4)
			Me.dashboardSqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.dashboardSqlDataSource1.ResultSchemaSerializable = resources.GetString("dashboardSqlDataSource1.ResultSchemaSerializable")
			' 
			' Dashboard1
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardSqlDataSource1})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.chartDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.chartDashboardItem1
			dashboardLayoutItem1.Weight = 50R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Weight = 100R
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Sales Overview"
			CType(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dashboardSqlDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
		Private dashboardSqlDataSource1 As DevExpress.DashboardCommon.DashboardSqlDataSource
	End Class
End Namespace
