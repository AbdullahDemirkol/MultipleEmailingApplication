using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopluMailGöndermeSistemi.Extensions
{
    public static class ExcelDataReaderExtensions
    {
        public static void GetExcelInformation(this IExcelDataReader excelReader,DataGridView listMailDataGrid,List<string> mails)
        {
            var counter = 0;
            while (excelReader.Read())
            {
                counter++;

                if (counter > 1)
                {
                    for (int i = 0; i < excelReader.RowCount; i++)
                    {
                        if (excelReader.GetString(i) != null)
                        {
                            if (excelReader.GetString(i).ToString().IsValidEmail())
                            {
                                var mail = excelReader.GetString(i).ToString();
                                mails.Add(mail);
                                listMailDataGrid.Rows.Add(mail);
                            }
                        }
                    }
                }
            }
        }
    }
}
