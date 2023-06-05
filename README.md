<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/648232952/2023.1)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1169475)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for WinForms - Custom Trend Indicator

The following example shows how to create a custom “Moving Average” indicator:

![Moving Average Indicator](Images/custom-indicator.png)

1. Create a [ChartCustomIndicator](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.ChartCustomIndicator) descendant (the `MovingIndicator` class in this example). `MovingIndicator` accepts a collection of data points, evaluates the values, and returns the resulting points. These points are used to draw the indicator.

2. Register the `MovingIndicator` type in [IndicatorFactory](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.IndicatorFactory) to make this type available as the indicator type in the Trend Indicators editor. Call the [Register](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.IndicatorFactory.Register--1(System.String)) method in your application before you save and load a dashboard to serialize and deserialize the indicator within the dashboard XML.

3. Create an instance of `MovingIndicator` and specify indicator settings.

4. Add `MovingIndicator` to the chart [indicators collection](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.ChartDashboardItem.Indicators) to display the configured indicator in the UI.

## Files to Review

- [Program.cs](./CS/WinformsIndicator/Program.cs) ([Program.vb](./VB/WinformsIndicator/Program.vb))
- [Form1.cs](./CS/WinformsIndicator/FormDesigner.cs) ([Form1.vb](./VB/WinformsIndicator/FormDesigner.vb))

## Documentation

- [Trend Indicators](https://docs.devexpress.com/Dashboard/404406/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/dashboard-item-settings/chart/trend-indicators?v=23.1)


