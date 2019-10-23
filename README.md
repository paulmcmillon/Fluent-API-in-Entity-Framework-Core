# Using Fluent API with Entity Framework Core
The repo contains one Visual Studio solution with one C# class library project.  The class library contains two folders, one with models and one with corresponding fluent API configurations for each model.  The goal of the project is to demonstrate how to leverage fluent API to sperate model configuration from model classes.  Not all database platforms, such as Oracle and MySQL, support all of annotations and navigation properties that might be encountered for a specific project.  Certain database object configurations do not have accompanying annotations as well, such as column default values, column constraints or cascade update and delete actions.  Microsoft recommends using fluent API going forward for code first entity framework implementations.

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
