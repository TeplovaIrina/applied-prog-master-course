using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Lab2Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateExcel();
            
        }
        
        private string SaveExcel()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel|*.xls";
            saveFileDialog1.Title = "Сохранить таблицу";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                return saveFileDialog1.FileName.ToString();
            }
            else
            {
                MessageBox.Show("Укажите файл!");
                return "";
            }
        }
        private void CreateExcel()
        {
            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            for (int i = 1; i < dataGridView1.RowCount + 1; i++)
            {
                for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
                {
                    worksheet.Rows[i].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].Value;
                }
            }

            excelapp.AlertBeforeOverwriting = false;


            workbook.SaveAs(SaveExcel());
            excelapp.Quit();
        }
    }
}
