using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;

namespace Crypta_lab_1
{
    class Export
    {
        public static void ToExcel(string path)
        {
            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("Worksheet1");
                excel.Workbook.Worksheets.Add("Worksheet2");

                var headerRow1 = new List<string[]>()
                {
                    new string[] { "Mon&_", "Frequency", "H1&_", "Mon!_", "Frequency", "H1!_"}
                };
                var headerRow2 = new List<string[]>()
                {
                    new string[] {"BigramsTouch&_", "Frequency", "H2", "BigramsTouch!_", "Frequency", "H2", "BigramsUntouch&_", "Frequency", "H2",  "BigramsUntouch!_", "Frequency", "H2"}
                };

                
                string headerRange1 = "A1:" + Char.ConvertFromUtf32(headerRow1[0].Length + 64) + "1";
                string headerRange2 = "A1:" + Char.ConvertFromUtf32(headerRow2[0].Length + 64) + "1";

                var worksheet1 = excel.Workbook.Worksheets["Worksheet1"];
                var worksheet2 = excel.Workbook.Worksheets["Worksheet2"];

                worksheet1.Cells[headerRange1].LoadFromArrays(headerRow1);
                worksheet2.Cells[headerRange2].LoadFromArrays(headerRow2);
                worksheet1.Cells[headerRange1].Style.Font.Color.SetColor(System.Drawing.Color.Blue);
                worksheet2.Cells[headerRange2].Style.Font.Color.SetColor(System.Drawing.Color.Blue);

                worksheet1.Cells[headerRange1].Style.Font.Size = 11;
                worksheet2.Cells[headerRange2].Style.Font.Size = 11;

                worksheet1.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet2.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                for (int j = 1; j < 13; j++)
                {
                    worksheet1.Column(j).Width = 12;
                    worksheet2.Column(j).Width = 16;
                }
                var TrueMonograms = Calculating.MonogarmsFrequency(path, true);
                var FalseMonograms = Calculating.MonogarmsFrequency(path, false);

                int i = 2;
                foreach (var item in TrueMonograms)
                {
                    worksheet1.Cells[i, 1].Value = item.Key.ToString();
                    worksheet1.Cells[i, 2].Value = item.Value;
                    i++;
                }
                worksheet1.Cells[2, 3].Value = Calculating.Entropy(Calculating.MonogarmsFrequency(path, true));
                worksheet1.Cells[2, 6].Value = Calculating.Entropy(Calculating.MonogarmsFrequency(path, false));
                i = 2;
                foreach (var val in FalseMonograms)
                {
                    worksheet1.Cells[i, 4].Value = val.Key.ToString();
                    worksheet1.Cells[i, 5].Value = val.Value;
                    i++;
                }


                var Bigrams1 = Calculating.BigramFrequancy(path, true, true);
                var Bigrams2 = Calculating.BigramFrequancy(path, true, false);
                var Bigrams3 = Calculating.BigramFrequancy(path, false, true);
                var Bigrams4 = Calculating.BigramFrequancy(path, false, false);

                i = 2;
                foreach (var item in Bigrams1)
                {
                    worksheet2.Cells[i, 1].Value = item.Key.ToString();
                    worksheet2.Cells[i, 2].Value = item.Value;
                    i++;
                }

                i = 2;
                foreach (var item in Bigrams2)
                {
                    worksheet2.Cells[i, 4].Value = item.Key.ToString();
                    worksheet2.Cells[i, 5].Value = item.Value;
                    i++;
                }

                i = 2;
                foreach (var item in Bigrams3)
                {
                    worksheet2.Cells[i, 7].Value = item.Key.ToString();
                    worksheet2.Cells[i, 8].Value = item.Value;
                    i++;
                }

                i = 2;
                foreach (var item in Bigrams4)
                {
                    worksheet2.Cells[i, 10].Value = item.Key.ToString();
                    worksheet2.Cells[i, 11].Value = item.Value;
                    i++;
                }

                worksheet2.Cells[2, 3].Value = Calculating.Entropy(Calculating.BigramFrequancy(path, true, true));
                worksheet2.Cells[2, 6].Value = Calculating.Entropy(Calculating.BigramFrequancy(path, true, false));
                worksheet2.Cells[2, 9].Value = Calculating.Entropy(Calculating.BigramFrequancy(path, false, true));
                worksheet2.Cells[2, 12].Value = Calculating.Entropy(Calculating.BigramFrequancy(path, false, false));
                //worksheet1.Cells[2, 1].LoadFromCollection(cellData.Keys);
                FileInfo excelFile = new FileInfo(@"C:\Users\nazar\source\repos\Crypta_FirstLab\Lab1.xlsx");
                excel.SaveAs(excelFile);
            }
            
        }
    }
}
