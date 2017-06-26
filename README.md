# EF6JoinExperiment
Test how Entity Framework generates SQL Joins

This is a Visual Studio 2017 C# Class Library Project with an accompanying Test Project.

Running the tests in the Test Project exercises the Entity Framework 6 database calls.

The SQL statements can be observed in the Output Window.

To use:
-Pull the repository
-Open the Solution
-Verify the connection strings in the app.config files are correct for your environment.  They are currently set to (localdb)\mssqllocaldb and Windows Authentication.  This matches the default Visual Studio 2017 installation.
-See the bacpac in the Supporting Files folder.  Restore this to your SQL server using SSMS.
-Use Find in Files to locate the GetStudentTutorsTest method
-Place a breakpoint on the Assert statement
-Place the cursor within the method
-Type Control+R+T to run the test in debug mode.
-When you hit the breakpoint, view the Output Windows to see the SQL statement

