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

