# Access SQL server database from .NET Core Console Application

This blog explains how you can return files to client from ASP.NET Core application using fileresult actionresults like FileContentResult, FileStreamResult, VirtualFileResult, PhysicalFileResult.

FileResult is an abstract base class for all file rendering action result, user can render file in the browser or download the required file using these built-in action results. By following this blog you will create a small application to understand FileResults by using all these FileResults.

## Files

1. **[Controller](https://github.com/geeksarray/aspnet-core-mvc-returning-file-using-fileresult/blob/main/Areas/Download/Controllers/EmployeeReportsController.cs)** - implemention of all different types of FileResult, including generating file from database.
2. **[MIME Dictionary](https://github.com/geeksarray/aspnet-core-mvc-returning-file-using-fileresult/blob/main/MIMETypeMapping.cs)** - has a dictionary of all MIME mapping with file extension.

Image file is generated using FileContentResult

![ASP.NET Core MVC File Result from Database](https://geeksarray.com/images/blog/asp-net-core-mvc-fileresult-from-database.png)

For more details of each FileResult please visit - https://geeksarray.com/blog/aspnet-core-mvc-returning-file-using-fileresult



