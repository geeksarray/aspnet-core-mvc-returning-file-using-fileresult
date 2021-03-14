using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System.IO;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MVC5Tutorial.Areas.Download.Controllers
{
    [Area("download")]
    [Route("/EmployeeReports")]
    public class EmployeeReportsController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public EmployeeReportsController(IWebHostEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
        }

        private string GetMIMEType(string fileName)
        {
            var provider = new Microsoft.AspNetCore.StaticFiles.FileExtensionContentTypeProvider();
            string contentType;
            if (!provider.TryGetContentType(fileName, out contentType))
            {
                contentType = "application/octet-stream";
            }
            return contentType;
        }

        [Route("/EmployeeReports/GetPhysicalFileResult")]
        public PhysicalFileResult GetPhysicalFileResult()
        {
            string mime = GetMIMEType("workplace-learning-report-2021.pdf");
            string path = "/wwwroot/download/workplace-learning-report-2021.pdf";
            return new PhysicalFileResult(_hostingEnvironment.ContentRootPath 
                + path, mime);
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/EmployeeReports/GetProductPhoto/{productid}")]
        public ActionResult GetProductPhoto(int productID)
        {
            byte[] fileContent;
            string contentType = string.Empty;
            string fileName = string.Empty;

            using (SqlConnection con =
                new SqlConnection("Data Source=DESKTOP-1NKM2FU;Initial Catalog=GeeksArray;Integrated Security=True")) 
            {
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection= con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT [LargePhoto], [LargePhotoFileName]  FROM " +
                        $" [AdventureWorks2017].[Production].[ProductPhoto] WHERE ProductPhotoID = { productID }";

                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        fileContent = (byte[])sdr["LargePhoto"];
                        contentType = GetMIMEType(sdr["LargePhotoFileName"].ToString());
                        fileName = sdr["LargePhotoFileName"].ToString();
                    }
                    con.Close();
                }
            }
            
            return new FileContentResult(fileContent, contentType);
        }

        [Route("/EmployeeReports/GetLearningReport")]
        public FileResult GetLearningReport()
        {
            string fileName = "workplace-learning-report-2021.pdf";
            string path = "/download/workplace-learning-report-2021.pdf";
            return File(path, GetMIMEType(fileName));
        }

        [Route("/EmployeeReports/GetFileContentResult")]
        public FileContentResult GetFileContentResult()
        {
            string path = "wwwroot/download/workplace-learning-report-2021.pdf";           
            byte[] fileContent = System.IO.File.ReadAllBytes(path); 
            return new FileContentResult(fileContent, "application/pdf");
        }

        [Route("/EmployeeReports/GetFileContentResultAsync")]
        public async Task<FileContentResult> GetFileContentResultAsync()
        {
            string path = "wwwroot/download/workplace-learning-report-2021.pdf";
            byte[] data = await System.IO.File.ReadAllBytesAsync(path);
            return new FileContentResult(data, "application/pdf");
        }

        [Route("/EmployeeReports/GetFileStreamResult")]
        public FileStreamResult GetFileStreamResult()
        {
            string path = "wwwroot/download/workplace-learning-report-2021.pdf";
            var stream = new MemoryStream(System.IO.File.ReadAllBytes(path));
            return new FileStreamResult(stream, new MediaTypeHeaderValue("application/pdf"))
            {
                FileDownloadName = "employee-report.pdf"
            };
        }

        [Route("/EmployeeReports/GetVirtualFileResult")]
        public VirtualFileResult GetVirtualFileResult()
        {
            string path = "download/workplace-learning-report-2021.pdf";
            return new VirtualFileResult(path, "application/pdf");
        }
    }
}




    