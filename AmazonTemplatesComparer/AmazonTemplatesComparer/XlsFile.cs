using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Bytescout.Spreadsheet;

namespace AmazonTemplatesComparer
{
    public class XlsFile
    {
        public static List<XlsFileStructure> Reader(string filePath)
        {
            Spreadsheet document = new Spreadsheet();
            document.LoadFromFile(filePath);
            Worksheet worksheet = document.Workbook.Worksheets.ByName("Template");

            var fileData = new List<XlsFileStructure>();

            for (var col = 0; col < worksheet.UsedRangeColumnMax; col++)
            {
                fileData.Add(new XlsFileStructure
                {
                    Name = worksheet.Cell(1, col).ValueAsString,
                    Value = worksheet.Cell(2, col).ValueAsString
                });
            }

            document.Close();
            return fileData;
        }

        public static void Writer(List<XlsChanges> changes)
        {
            Spreadsheet document = new Spreadsheet();
            Worksheet Sheet = document.Workbook.Worksheets.Add("Changes");
            Sheet.Cell("A1").Value = "Previous name";
            Sheet.Columns[0].Width = 250;
            Sheet.Cell("B1").Value = "New name";
            Sheet.Columns[1].Width = 250;
            Sheet.Cell("D1").Value = "Previous value";
            Sheet.Columns[3].Width = 250;
            Sheet.Cell("E1").Value = "New value";
            Sheet.Columns[4].Width = 250;

            var i = 2;
            foreach (var change in changes)
            {
                Sheet.Cell("A" + i).Value = change.OldName;
                Sheet.Cell("B" + i).Value = change.NewName;
                Sheet.Cell("D" + i).Value = change.OldValue;
                Sheet.Cell("E" + i).Value = change.NewValue;
                i++;
            }


            // delete output file if exists already
            if (File.Exists("Output.xls"))
            {
                File.Delete("Output.xls");
            }

            document.SaveAs("Output.xls");

            document.Close();
        }
    }
}
