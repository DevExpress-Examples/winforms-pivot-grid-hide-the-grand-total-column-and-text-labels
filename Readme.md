<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582066/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2514)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/RemoveGridLinesExample/Form1.cs) (VB: [Form1.vb](./VB/RemoveGridLinesExample/Form1.vb))
<!-- default file list end -->
# How to Hide Unnecessary Grid Lines and Text


This example demonstrates how hide the grand total column when there are no Data or Column fields, clear grid lines and remove the "Drop Data Items Here", "Drop Column Fields Here", "Drop Filter Fields Here" labels.

![screenshot](/images/screenshot.png)

API in this example:

* [PivotGridControl.CustomDrawFieldValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomDrawFieldValue) event
* [PivotGridControl.Appearance.Lines](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridAppearancesBase.Lines) property
* [PivotGridLocalizer](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.Localization.PivotGridLocalizer) class

