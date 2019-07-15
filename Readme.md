<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/RemoveGridLinesExample/Form1.cs) (VB: [Form1.vb](./VB/RemoveGridLinesExample/Form1.vb))
<!-- default file list end -->
# How to Hide Unnecessary Grid Lines and Text


This example demonstrates how hide the grand total column when there are no Data or Column fields, clear grid lines and remove the "Drop Data Items Here", "Drop Column Fields Here", "Drop Filter Fields Here" labels.

![screenshot](/images/screenshot.png)

API in this example:

* [PivotGridControl.CustomDrawFieldValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomDrawFieldValue) event
* [PivotGridControl1.Appearance.Lines](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridAppearancesBase.Lines) property
* [PivotGridLocalizer](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.Localization.PivotGridLocalizer) class

