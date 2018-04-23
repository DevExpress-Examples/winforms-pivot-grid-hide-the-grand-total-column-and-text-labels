using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Localization;

namespace WindowsApplication34
{
    public partial class Form1 : Form
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
            pivotGridControl1.CustomDrawFieldValue += new PivotCustomDrawFieldValueEventHandler(pivotGridControl1_CustomDrawFieldValue);
            pivotGridControl1.Appearance.Lines.BackColor = Color.Transparent;            
            pivotGridControl1.EndUpdate();

        }

        void pivotGridControl1_CustomDrawFieldValue(object sender, PivotCustomDrawFieldValueEventArgs e)
        {
            if (e.Area == DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                e.Handled = true;
            }

        }

        private void InitializeFields()
        {
            pivotGridControl1.Fields.Add("Type", DevExpress.XtraPivotGrid.PivotArea.RowArea);
            pivotGridControl1.Fields.Add("Product", DevExpress.XtraPivotGrid.PivotArea.RowArea);
            PivotGridField fieldYear = new PivotGridField("Date", PivotArea.RowArea);
            fieldYear.Name = "FieldYear";
            fieldYear.Caption = fieldYear.Name;
            fieldYear.GroupInterval = PivotGroupInterval.DateYear;
            PivotGridField fieldMonth = new PivotGridField("Date", PivotArea.RowArea);
            fieldMonth.Name = "FieldMonth";
            fieldMonth.Caption = fieldMonth.Name;
            fieldMonth.GroupInterval = PivotGroupInterval.DateMonth;
            pivotGridControl1.Fields.AddRange(new PivotGridField[] { fieldYear, fieldMonth });
            pivotGridControl1.Fields.Add("Flag", DevExpress.XtraPivotGrid.PivotArea.RowArea);
        }
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Type", typeof(string));
            tbl.Columns.Add("Product", typeof(string));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("Flag", typeof(bool));

            Random r = new Random();
            for (int i = 0; i < RowCount; i++)

                for (int j = 0; j < RowCount; j++)
                    tbl.Rows.Add(new object[] { String.Format("Type {0}", i % 5), String.Format("Product {0}", i % 3), DateTime.Now.AddYears(j % 7).AddMonths(j % 9), i % 2 == 0 });
            return tbl;
        }

    }
    public class MyLocalizer : PivotGridResLocalizer
    {
        public override string GetLocalizedString(PivotGridStringId id)
        {
            if (id == PivotGridStringId.DataHeadersCustomization || id == PivotGridStringId.ColumnHeadersCustomization) return String.Empty;
            return base.GetLocalizedString(id);
        }
    }

}