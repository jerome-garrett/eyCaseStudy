using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using EYCaseStudy.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EYCaseStudy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpPost]
        public IActionResult UploadFile()
        {
            var file = Request.Form.Files[0];
            using (var stream = file.OpenReadStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    var json = reader.ReadToEnd();
                    var records = JsonConvert.DeserializeObject<List<Record>>(json);
                }
            }
            
            return Ok();
        }

        private static void ReadData(AccountLevels data)
        {

        }
    }
}