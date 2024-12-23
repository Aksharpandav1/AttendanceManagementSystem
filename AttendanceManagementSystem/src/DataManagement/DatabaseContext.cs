using Microsoft.EntityFrameworkCore;

namespace AttendanceManagementSystem.DataManagement
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }

        // Additional DbSet properties for other data tables can be added here
    }
}