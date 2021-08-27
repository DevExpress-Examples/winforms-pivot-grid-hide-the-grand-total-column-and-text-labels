<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582066/10.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2514)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication34/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication34/Form1.vb))
* [Program.cs](./CS/WindowsApplication34/Program.cs) (VB: [Program.vb](./VB/WindowsApplication34/Program.vb))
<!-- default file list end -->
# How to hide the Grand Total column and Data Area if there is no Data and Column Fields


<p>This example demonstrates how hide the grand total column when the XtraPivotGrid control does not contains any Data or Column fields. To achieve the required result, it is necessary to use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomDrawFieldValuetopic">PivotGridControl.CustomDrawFieldValue</a> event to hide Column Field Values. In additional, it is necessary to set the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridAppearancesBase_Linestopic">PivotGridAppearancesBase.Lines</a> color to <i>Color.Transparent</i>. The <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridLocalizationPivotGridLocalizerMembersTopicAll">PivotGridLocalizer </a> object is used to  hide "Drop Column Fields Here" and "Drop Data Fields Here"  inscriptions.</p>

<br/>


