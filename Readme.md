# How to hide the Grand Total column and Data Area if there is no Data and Column Fields


<p>This example demonstrates how hide the grand total column when the XtraPivotGrid control does not contains any Data or Column fields. To achieve the required result, it is necessary to use the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomDrawFieldValuetopic">PivotGridControl.CustomDrawFieldValue</a> event to hide Column Field Values. In additional, it is necessary to set the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridAppearancesBase_Linestopic">PivotGridAppearancesBase.Lines</a> color to <i>Color.Transparent</i>. The <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridLocalizationPivotGridLocalizerMembersTopicAll">PivotGridLocalizer </a> object is used to  hide "Drop Column Fields Here" and "Drop Data Fields Here"  inscriptions.</p>

<br/>


