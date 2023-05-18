using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

namespace Getting_Real
{
    public class DataHandler
    {
        public List<Machine> ReadExcel()
        {
            // Specify the file path of the Excel file to be read
            string filePath =
                "C:\\Users\\Ervin\\Desktop\\test repository\\Getting-real\\DelAfRAP-000478simplificeretA(134)1.xlsx";

            // Create an instance of the Excel application
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb;
            Worksheet ws;

            // Open the Excel file and select the first worksheet
            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            // Define the ranges of different columns in the worksheet
            Microsoft.Office.Interop.Excel.Range intervalRange = ws.Range["A2:A888"];
            Microsoft.Office.Interop.Excel.Range weekMonthYearRange = ws.Range["B2:B888"];
            Microsoft.Office.Interop.Excel.Range functionLocationRange = ws.Range["C2:C888"];
            Microsoft.Office.Interop.Excel.Range machineNameRange = ws.Range["D2:D888"];
            Microsoft.Office.Interop.Excel.Range coordinatesRange = ws.Range["E2:E888"];
            Microsoft.Office.Interop.Excel.Range lubricationPointRange = ws.Range["F2:F888"];
            Microsoft.Office.Interop.Excel.Range lubricationOilTypeRange = ws.Range["G2:G888"];
            Microsoft.Office.Interop.Excel.Range greaseTypeRange = ws.Range["H2:H888"];
            Microsoft.Office.Interop.Excel.Range volumeLiterRange = ws.Range["I2:I888"];
            Microsoft.Office.Interop.Excel.Range volumeGramsRange = ws.Range["J2:J888"];

            List<Machine> machines = new List<Machine>();

            // Loop through each row in the worksheet
            for (int i = 1; i <= intervalRange.Count; i++)
            {
                // Read the values from each column in the current row
                string interval = intervalRange.Cells[i, 1].Value.ToString();
                string weekMonthYear = weekMonthYearRange.Cells[i, 1].Value.ToString();
                string functionLocation = functionLocationRange.Cells[i, 1].Value.ToString();
                string machineName = machineNameRange.Cells[i, 1].Value.ToString();
                string coordinates = coordinatesRange.Cells[i, 1].Value.ToString();
                string lubricationPoint = lubricationPointRange.Cells[i, 1].Value.ToString();
                string lubricationOilType = lubricationOilTypeRange.Cells[i, 1].Value.ToString();
                string greaseType = greaseTypeRange.Cells[i, 1].Value.ToString();
                string volumeLiter = volumeLiterRange.Cells[i, 1].Value.ToString();
                string volumeGrams = volumeGramsRange.Cells[i, 1].Value.ToString();

                // Create a new Machine object with the read values and add it to the list
                Machine machine = new Machine(interval, weekMonthYear, functionLocation, machineName, coordinates,
                    lubricationPoint, lubricationOilType, greaseType, volumeLiter, volumeGrams);
                machines.Add(machine);
            }

            // Close the workbook and quit the Excel application
            wb.Close();
            excel.Quit();

            // Return the list of machines
            return machines;
        }

        public void SaveList(List<Machine> machines)
        {
            // Create a file stream to write to a file called "tekst.txt"
            FileStream fileStream = new FileStream("tekst.txt", FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            // Write each machine's string representation to the file
            foreach (var machine in machines)
            {
                streamWriter.WriteLine(machine.ToString());

                // Close the stream writer and release the file

            }
        }

    }

}