using System;
using System.Collections.Generic;
using System.IO;
using OfficeOpenXml;

namespace AttendanceManagementSystem.ReportGeneration
{
    public class ReportGenerator
    {
        private readonly List<AttendanceRecord> _attendanceRecords;

        public ReportGenerator(List<AttendanceRecord> attendanceRecords)
        {
            _attendanceRecords = attendanceRecords;
        }

        public void GenerateReport(string filePath)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Attendance Report");
                worksheet.Cells[1, 1].Value = "SrNo";
                worksheet.Cells[1, 2].Value = "Name";
                worksheet.Cells[1, 3].Value = "Date";

                for (int i = 0; i < _attendanceRecords.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = _attendanceRecords[i].SrNo;
                    worksheet.Cells[i + 2, 2].Value = _attendanceRecords[i].Name;
                    worksheet.Cells[i + 2, 3].Value = _attendanceRecords[i].Date.ToString("yyyy-MM-dd");
                }

                package.SaveAs(new FileInfo(filePath));
            }
        }

        public void ExportToExcel(string filePath)
        {
            GenerateReport(filePath);
        }
    }
}