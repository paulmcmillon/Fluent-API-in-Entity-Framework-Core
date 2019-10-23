# Using Fluent API with Entity Framework Core
The repo contains one Visual Studio solution with one C# class library project.  The class library contains two folders, one with models and one with corresponding fluent API configurations for each model.  The goal of the project is to demonstrate how to leverage fluent API to sperate model configuration from model classes.  Not all database platforms, such as Oracle and MySQL, support all the annotations and navigation properties that might be encountered for a specific project.  Certain database object configurations do not have accompanying annotations as well, such as column default values, column constraints or cascade update and delete actions.  Microsoft recommends using fluent API going forward for code first entity framework implementations.

## Tools and Frameworks
Visual Studio 2017 Version 15.9.16

Microsoft .NET Framework Version 4.8.03572

Nuget Packages
* Microsoft.NETCore.App v 2.2.0
* Microsoft.EntityFrameworkCore.SqlServer 2.2.4
* Microsoft.EntityFrameworkCore.Design 2.2.4
* Microsoft.EntityFrameworkCore.Tools 2.2.4

Microsoft SQL Server 2017 - SQL Server versions 2012 and higher are supported including the community versions.  Microsoft Azure SQL Database is also supported

## Setup
After cloning the project, you will need a connection to an appropriate version of SQL Server or Azure SQL Database instance.  Create and empty database with any name you like.

Open the project in Visual Studio and locate the entity framework DbContext class cleverly named **DatabaseContext.cs** and provide the server name and database name for your environment in the connection string...see code snippets below.

With SQL server integrated security enabled

`        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)`
        `{`
            `if (!optionsBuilder.IsConfigured)`
            `{`
                `optionsBuilder.UseSqlServer("Data Source=[SERVERNAME];Initial Catalog=[DATABASENAME];Integrated Security=True;")`
                `.ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));`
            `}`
       
NOTE: If using Azure SQL you'll need to replace the connection string and your environment variables with...

`Server=tcp:[ServerName].database.windows.net,1433;Initial Catalog=[DatabaseName];Persist Security Info=False;User ID=[UserId];Password=[password];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;`

Now that you have your empty database and Dbcontext configured, open the Package Manager Console in visual studio (View -> Other Windows -> Package Manager Console) and type _add-migration_ [MigrationName].  You may use any name you like, just omit any spaces.  This will create three files in a new folder named Migrations.  If you receive any errors, double check your connection string and login credentials.  Next type _update-database_ in the Package Manager Console.  After the package manager completes execution of the migration scripts you can check your database for your table entites.
