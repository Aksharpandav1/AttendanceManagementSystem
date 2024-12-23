# Attendance Management System

## Overview
The Attendance Management System is a comprehensive application designed to facilitate efficient attendance tracking, data management, and report generation for organizations. This system allows users to manage attendance records seamlessly and generate reports for analysis.

## Features
- **Data Management**: 
  - Add, retrieve, and search attendance entries.
  - Manage data sheets with specified columns.

- **Attendance Tracking**: 
  - Mark attendance efficiently every Thursday.
  - Retrieve attendance records for individuals.

- **Report Generation**: 
  - Generate detailed attendance reports.
  - Export reports to Excel format for easy sharing and analysis.

## Project Structure
```
AttendanceManagementSystem
├── src
│   ├── DataManagement
│   │   ├── DataManager.cs
│   │   └── DatabaseContext.cs
│   ├── AttendanceTracking
│   │   ├── AttendanceTracker.cs
│   │   └── AttendanceRecord.cs
│   ├── ReportGeneration
│   │   ├── ReportGenerator.cs
│   │   └── ReportTemplate.cs
│   ├── Program.cs
│   └── Startup.cs
├── AttendanceManagementSystem.sln
└── README.md
```

## Setup Instructions
1. Clone the repository to your local machine.
2. Open the solution file `AttendanceManagementSystem.sln` in your development environment.
3. Restore the necessary packages and dependencies.
4. Configure the database connection in `DatabaseContext.cs`.
5. Build and run the application.

## Usage Guidelines
- Use the `DataManager` class to manage attendance entries.
- Utilize the `AttendanceTracker` class to mark and retrieve attendance.
- Generate reports using the `ReportGenerator` class and export them as needed.

## Contributing
Contributions are welcome! Please submit a pull request or open an issue for any enhancements or bug fixes.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.