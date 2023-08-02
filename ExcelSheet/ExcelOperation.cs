using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelSheet
{
    public class ExcelOperation
    {


        public static void GetDataFromSheet(string FilePath , string sheetpath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var dataList = ReadDataFromExcel(FilePath, sheetpath);

            foreach (var data in dataList)
            {
                Console.WriteLine(data.ToString());
            }

        }

        public static List<Person> ReadDataFromExcel(string filePath, string sheetName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            List<Person> dataList = new List<Person>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[sheetName];

                
                int rowCount = worksheet.Dimension.Rows;
                int ColCount = worksheet.Dimension.Columns;

                for (int row = 1; row <= rowCount; row++)
                {
                    
                    var name = worksheet.Cells[row, 1].Value;
                    var phone = worksheet.Cells[row, 2].Value;
                    var email = worksheet.Cells[row, 3].Value;

                    phone = Convert.ToString(phone);



                    if (name != null && phone != null && email != null)
                        {
                        Person person = new Person();
                        person.Name = (string)name;
                        person.Phone = (string)phone;
                        person.Email = (string)email;
              
                            dataList.Add(person);
                        }
                    }
                }
            return dataList;

        }
    
    }
}
