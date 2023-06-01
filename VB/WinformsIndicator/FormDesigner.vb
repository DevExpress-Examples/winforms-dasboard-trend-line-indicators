Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardCommon.ViewerData

Namespace WinForm
	Partial Public Class FormDesigner
		Inherits Form

		Public Sub New()
			Try
				IndicatorFactory.Register(Of MovingIndicator)("Moving average")
			Catch e As Exception
				MessageBox.Show(e.Message)
			End Try
			InitializeComponent()
			Dim dashboard = New Dashboard1()
			Dim chartItem As ChartDashboardItem = TryCast(dashboard.Items.First(Function(x) x.ComponentName = "chartDashboardItem1"), ChartDashboardItem)
			Dim trendLine As New MovingIndicator() With {
				.Name = "MovingLine1",
				.Value = "DataItem1",
				.ValueLevel = DevExpress.XtraCharts.ValueLevel.Value,
				.Color = Color.Orange,
				.LegendText = "Moving Average"
			}
			chartItem.Indicators.Add(trendLine)
			dashboardViewer.Dashboard = dashboard
			dashboardViewer.CreateRibbon()
			dashboardViewer.CreateCustomItemBars()
		End Sub
	End Class

	Public Class MovingIndicator
		Inherits ChartCustomIndicator

		Protected Overrides Function Calculate(ByVal values As Dictionary(Of AxisPoint, Decimal?)) As Dictionary(Of AxisPoint, Object)
			Dim items = New Dictionary(Of AxisPoint, Object)(values.Count)

			Dim sum = Decimal.Zero
			Dim count = 0
			For Each point As KeyValuePair(Of AxisPoint, Decimal?) In values
				If count = 0 Then
					items.Add(point.Key, Nothing)
				Else
					items.Add(point.Key, sum / count)
				End If
				sum += If(point.Value, 0)
				count += 1
			Next point

			Return items
		End Function
	End Class
End Namespace
