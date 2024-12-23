using System;
using System.Collections.Generic;
using System.Linq;

namespace AttendanceManagementSystem.DataManagement
{
    public class DataManager
    {
        private readonly DatabaseContext _context;

        public DataManager(DatabaseContext context)
        {
            _context = context;
        }

        public void AddEntry(string name, DateTime date)
        {
            var entry = new AttendanceRecord
            {
                SrNo = _context.AttendanceRecords.Count() + 1,
                Name = name,
                Date = date
            };
            _context.AttendanceRecords.Add(entry);
            _context.SaveChanges();
        }

        public List<AttendanceRecord> GetAllEntries()
        {
            return _context.AttendanceRecords.ToList();
        }

        public List<AttendanceRecord> SearchEntries(string name)
        {
            return _context.AttendanceRecords
                .Where(record => record.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}