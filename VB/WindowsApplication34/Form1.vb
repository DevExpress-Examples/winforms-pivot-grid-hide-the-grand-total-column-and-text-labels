Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Localization

Namespace WindowsApplication34

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            PivotGridLocalizer.Active = New MyLocalizer()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            pivotGridControl1.BeginUpdate()
            pivotGridControl1.DataSource = CreateTable(20)
            InitializeFields()
            AddHandler pivotGridControl1.CustomDrawFieldValue, New PivotCustomDrawFieldValueEventHandler(AddressOf pivotGridControl1_CustomDrawFieldValue)
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
            pivotGridControl1.Fields.Add("Type", PivotArea.RowArea)
            pivotGridControl1.Fields.Add("Product", PivotArea.RowArea)
            Dim fieldYear As PivotGridField = New PivotGridField("Date", PivotArea.RowArea)
            fieldYear.Name = "FieldYear"
            fieldYear.Caption = fieldYear.Name
            fieldYear.GroupInterval = PivotGroupInterval.DateYear
            Dim fieldMonth As PivotGridField = New PivotGridField("Date", PivotArea.RowArea)
            fieldMonth.Name = "FieldMonth"
            fieldMonth.Caption = fieldMonth.Name
            fieldMonth.GroupInterval = PivotGroupInterval.DateMonth
            pivotGridControl1.Fields.AddRange(New PivotGridField() {fieldYear, fieldMonth})
            pivotGridControl1.Fields.Add("Flag", PivotArea.RowArea)
        End Sub

        Private Function CreateTable(ByVal RowCount As Integer) As DataTable
            Dim tbl As DataTable = New DataTable()
            tbl.Columns.Add("Type", GetType(String))
            tbl.Columns.Add("Product", GetType(String))
            tbl.Columns.Add("Date", GetType(Date))
            tbl.Columns.Add("Flag", GetType(Boolean))
            Dim r As Random = New Random()
            For i As Integer = 0 To RowCount - 1
                For j As Integer = 0 To RowCount - 1
                    tbl.Rows.Add(New Object() {String.Format("Type {0}", i Mod 5), String.Format("Product {0}", i Mod 3), Date.Now.AddYears(j Mod 7).AddMonths(j Mod 9), i Mod 2 = 0})
                Next
            Next

            Return tbl
        End Function
    End Class

    Public Class MyLocalizer
        Inherits PivotGridResLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As PivotGridStringId) As String
            If id = PivotGridStringId.DataHeadersCustomization OrElse id = PivotGridStringId.ColumnHeadersCustomization Then Return String.Empty
            Return MyBase.GetLocalizedString(id)
        End Function
    End Class
End Namespace
