public class AttendanceTracker
{
    private readonly DatabaseContext _context;

    public AttendanceTracker(DatabaseContext context)
    {
        _context = context;
    }

    public void MarkAttendance(string name)
    {
        var attendanceRecord = new AttendanceRecord
        {
            SrNo = GetNextSrNo(),
            Name = name,
            Date = DateTime.Now
        };

        _context.AttendanceRecords.Add(attendanceRecord);
        _context.SaveChanges();
    }

    public List<AttendanceRecord> GetAttendanceRecords()
    {
        return _context.AttendanceRecords.ToList();
    }

    private int GetNextSrNo()
    {
        return _context.AttendanceRecords.Count() + 1;
    }
}