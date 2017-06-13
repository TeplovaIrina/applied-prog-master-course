using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exc = Microsoft.Office.Interop.Excel;

namespace ConsoleApplication5
{
    class exel
    {
        public void GetIn()
        {
            Exc.Application ObjWorkExcel = new Exc.Application(); //открыть эксель
            Exc.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open(@"d:\ex.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing); //открыть файл
            Exc.Worksheet ObjWorkSheet = (Exc.Worksheet)ObjWorkBook.Sheets[1]; //получить 1 лист
            var lastCell = ObjWorkSheet.Cells.SpecialCells(Exc.XlCellType.xlCellTypeLastCell);//1 ячейку
            //-------------------------------------
            int lastColumn = (int)lastCell.Column;
            int lastRow = (int)lastCell.Row;
            //-------------------------------------
            string[,] list = new string[lastColumn, lastRow]; // массив значений с листа равен по размеру листу
            for (int i = 0; i < (int)lastColumn; i++) //по всем колонкам
                for (int j = 0; j < (int)lastRow; j++) // по всем строкам
                    list[i, j] = ObjWorkSheet.Cells[j + 1, i + 1].Text.ToString();//считываем текст в строку
            ObjWorkBook.Close(false, Type.Missing, Type.Missing); //закрыть не сохраняя
            ObjWorkExcel.Quit(); // выйти из экселя
            GC.Collect(); // убрать за собой
            for (int i = 0; i < lastColumn; i++) //по всем колонкам
                for (int j = 0; j < lastRow; j++) // по всем строкам 
                    Console.WriteLine(list[i, j]);//выводим строку
        }
    }
}
