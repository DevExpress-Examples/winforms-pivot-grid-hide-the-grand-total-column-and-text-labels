using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Localization;
using System;
using System.Data;
using System.Drawing;

namespace RemoveGridLinesExample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            PivotGridLocalizer.Active = new MyLocalizer();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pivotGridControl1.BeginUpdate();
            pivotGridControl1.DataSource = CreateTable(20);
            InitializeFields();
            pivotGridControl1.CustomDrawFieldValue += pivotGridControl1_CustomDrawFieldValue;
            pivotGridControl1.Appearance.Lines.BackColor = Color.Transparent;
            pivotGridControl1.EndUpdate();

        }

        void pivotGridControl1_CustomDrawFieldValue(object sender, PivotCustomDrawFieldValueEventArgs e)
        {
            if (e.Area == PivotArea.ColumnArea)
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                e.Handled = true;
            }

        }

        private void InitializeFields()
        {
            pivotGridControl1.Fields.Add("Type", PivotArea.RowArea);
            pivotGridControl1.Fields.Add("Product", PivotArea.RowArea);
            PivotGridField fieldYear = new PivotGridField("Date", PivotArea.RowArea);
            fieldYear.Name = "FieldYear";
            fieldYear.Caption = fieldYear.Name;
            fieldYear.GroupInterval = PivotGroupInterval.DateYear;
            PivotGridField fieldMonth = new PivotGridField("Date", PivotArea.RowArea);
            fieldMonth.Name = "FieldMonth";
            fieldMonth.Caption = fieldMonth.Name;
            fieldMonth.GroupInterval = PivotGroupInterval.DateMonth;
            pivotGridControl1.Fields.AddRange(new PivotGridField[] { fieldYear, fieldMonth });
            pivotGridControl1.Fields.Add("Flag", PivotArea.RowArea);
        }
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Type", typeof(string));
            tbl.Columns.Add("Product", typeof(string));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("Flag", typeof(bool));

            for (int i = 0; i < RowCount; i++)

                for (int j = 0; j < RowCount; j++)
                    tbl.Rows.Add(new object[] {
                        String.Format("Type {0}", i % 5),
                        String.Format("Product {0}", i % 3),
                        DateTime.Now.AddYears(j % 7).AddMonths(j % 9), i % 2 == 0 });
            return tbl;
        }

    }
    public class MyLocalizer : PivotGridResLocalizer
    {
        public override string GetLocalizedString(PivotGridStringId id)
        {
            if (id == PivotGridStringId.DataHeadersCustomization
                || id == PivotGridStringId.ColumnHeadersCustomization
                || id == PivotGridStringId.FilterHeadersCustomization)
                return String.Empty;
            return base.GetLocalizedString(id);
        }
    }

}