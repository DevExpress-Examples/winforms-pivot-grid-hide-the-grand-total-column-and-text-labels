<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2514)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Pivot Grid for Winforms - Hide Unnecessary Grid Lines and Text

This example demonstrates how to clear grid lines and hide the following Pivot Grid elements:

- The grand total column when there are no Data or Column fields.
- The "Drop Data Items Here", "Drop Column Fields Here", and "Drop Filter Fields Here" labels.

![screenshot](/images/screenshot.png)

API in this example:

* [PivotGridControl.CustomDrawFieldValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomDrawFieldValue) event
* [PivotGridControl.Appearance.Lines](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridAppearancesBase.Lines) property
* [PivotGridLocalizer](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.Localization.PivotGridLocalizer) class

## Files to Review

* [Form1.cs](./CS/RemoveGridLinesExample/Form1.cs) (VB: [Form1.vb](./VB/RemoveGridLinesExample/Form1.vb))

## Documentation

[Custom Draw](https://docs.devexpress.com/WindowsForms/1817/controls-and-libraries/pivot-grid/appearance/custom-draw)

## More Examples

- [Pivot Grid for WinForms - Change the Field Value Header Background](https://github.com/DevExpress-Examples/winforms-pivot-change-the-field-value-header-appearance-backcolor)
- [Pivot Grid for WinForms - Draw a Custom Element When a User Hovering Over Field Value with a Mouse](https://github.com/DevExpress-Examples/winforms-pivot-grid-draw-a-custom-element-on-mouse-hover)
