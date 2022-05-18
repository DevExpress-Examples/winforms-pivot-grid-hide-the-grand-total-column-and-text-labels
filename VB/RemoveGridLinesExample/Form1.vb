Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Localization
Imports System
Imports System.Data
Imports System.Drawing

Namespace RemoveGridLinesExample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			PivotGridLocalizer.Active = New MyLocalizer()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			pivotGridControl1.BeginUpdate()
			pivotGridControl1.DataSource = CreateTable(20)
			InitializeFields()
			AddHandler pivotGridControl1.CustomDrawFieldValue, AddressOf pivotGridControl1_CustomDrawFieldValue
			pivotGridControl1.Appearance.Lines.BackColor = Color.Transparent
			pivotGridControl1.EndUpdate()

		End Sub

		Private Sub pivotGridControl1_CustomDrawFieldValue(ByVal sender As Object, ByVal e As PivotCustomDrawFieldValueEventArgs)
			If e.Area = PivotArea.ColumnArea Then
				e.Graphics.FillRectangle(Brushes.White, e.Bounds)
				e.Handled = True
			End If

		End Sub

		Private Sub InitializeFields()
			pivotGridControl1.Fields.AddDataSourceColumn("Type", PivotArea.RowArea)
			pivotGridControl1.Fields.AddDataSourceColumn("Product", PivotArea.RowArea)
			Dim fieldYear As New PivotGridField()
			fieldYear.Area = PivotArea.RowArea
			fieldYear.DataBinding = New DataSourceColumnBinding("Date", PivotGroupInterval.DateYear)
			fieldYear.Name = "FieldYear"
			fieldYear.Caption = fieldYear.Name
			Dim fieldMonth As New PivotGridField()
			fieldMonth.Area = PivotArea.RowArea
			fieldMonth.DataBinding = New DataSourceColumnBinding("Date", PivotGroupInterval.DateMonth)
			fieldMonth.Name = "FieldMonth"
			fieldMonth.Caption = fieldMonth.Name
			pivotGridControl1.Fields.AddDataSourceColumn("Flag", PivotArea.RowArea)
		End Sub
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Type", GetType(String))
			tbl.Columns.Add("Product", GetType(String))
			tbl.Columns.Add("Date", GetType(Date))
			tbl.Columns.Add("Flag", GetType(Boolean))

			For i As Integer = 0 To RowCount - 1

				For j As Integer = 0 To RowCount - 1
					tbl.Rows.Add(New Object() { String.Format("Type {0}", i Mod 5), String.Format("Product {0}", i Mod 3), Date.Now.AddYears(j Mod 7).AddMonths(j Mod 9), i Mod 2 = 0 })
				Next j
			Next i
			Return tbl
		End Function

	End Class
	Public Class MyLocalizer
		Inherits PivotGridResLocalizer

		Public Overrides Function GetLocalizedString(ByVal id As PivotGridStringId) As String
			If id = PivotGridStringId.DataHeadersCustomization OrElse id = PivotGridStringId.ColumnHeadersCustomization OrElse id = PivotGridStringId.FilterHeadersCustomization Then
				Return String.Empty
			End If
			Return MyBase.GetLocalizedString(id)
		End Function
	End Class

End Namespace