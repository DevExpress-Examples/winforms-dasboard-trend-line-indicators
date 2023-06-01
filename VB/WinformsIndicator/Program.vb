Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI

Namespace WinForm
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Dashboard.CustomItemMetadataTypes.Register(Of SimpleTableMetadata)()

			Application.Run(New FormDesigner())
		End Sub
	End Module

	<DisplayName("Simple Table"), CustomItemDescription("Simple Table description"), CustomItemImage("TutorialsCustomItems.Images.CustomGrid.svg")>
	Friend Class SimpleTableMetadata
		Inherits CustomItemMetadata

		<DisplayName("Measure"), EmptyDataItemPlaceholder("MeasureColumn")>
		Public Property MeasureColumn() As Measure
			Get
				Return GetPropertyValue(Of Measure)()
			End Get
			Set(ByVal value As Measure)
				SetPropertyValue(value)
			End Set
		End Property
		<DisplayName("Dimensions"), EmptyDataItemPlaceholder("DimensionColumn")>
		Public ReadOnly Property DimensionColumns() As New DimensionCollection()
	End Class

	Public Class SimpleTableProvider
		Inherits CustomControlProviderBase

		Private view As GridView
		Private grid As GridControl
		Protected Overrides ReadOnly Property Control() As Control
			Get
				Return grid
			End Get
		End Property
		Public Sub New()
			grid = New GridControl()
			view = New GridView()
			view.OptionsView.ShowGroupPanel = False
			AddHandler view.CustomColumnDisplayText, AddressOf View_CustomColumnDisplayText
			grid.MainView = view
		End Sub
		Protected Overrides Sub UpdateControl(ByVal customItemData As CustomItemData)
			Dim flatData As DashboardFlatDataSource = customItemData.GetFlatData()
			grid.DataSource = flatData
			view.PopulateColumns()
			view.BestFitColumns()
		End Sub
		Private Sub View_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
			Dim data As DashboardFlatDataSource = CType(grid.DataSource, DashboardFlatDataSource)
			e.DisplayText = data.GetDisplayText(e.Column.FieldName, e.ListSourceRowIndex)
		End Sub

		Protected Overrides Function GetPrintableControl(ByVal customItemData As CustomItemData, ByVal exportInfo As CustomItemExportInfo) As XRControl
			Dim container As New PrintableComponentContainer()
			container.PrintableComponent = grid
			Return container
		End Function
	End Class
End Namespace
