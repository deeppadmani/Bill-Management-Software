using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ExcelSaiDevaCraker
{
    class classExcel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public classExcel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        public void Save()
        {
            wb.Save();
        }
        public string ReadCell(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
            {
                return ws.Cells[i, j].Value.ToString();
            }
            else
                return "";
        }

        public void WriteToCell(int i, int j,string data)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = data;
        }
        public void CloseFile()
        {
            wb.Close(0);
        }

        public int FindLastRow()
        {
            int lastUsedRow;
            lastUsedRow = ws.Cells.Find("*", System.Reflection.Missing.Value,
                           System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                           _Excel.XlSearchOrder.xlByRows, _Excel.XlSearchDirection.xlPrevious,
                           false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

            return lastUsedRow;
        }

        public int FindLastColumn()
        {
            // Find the last real column
            int lastUsedColumn;
            lastUsedColumn = ws.Cells.Find("*", System.Reflection.Missing.Value,
                                           System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                           _Excel.XlSearchOrder.xlByColumns, _Excel.XlSearchDirection.xlPrevious,
                                           false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Column;
            return lastUsedColumn;
        }
    };
}