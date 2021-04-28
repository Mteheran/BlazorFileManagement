using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using shared;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;
        private readonly IAzureStorageService _azureFile;

        public FileController(ILogger<FileController> logger, IAzureStorageService azure)
        {
            _logger = logger;
            _azureFile = azure;
        }

        [HttpPost]
        public IActionResult Post([FromBody] BlazorFile file)
        {
            _logger.LogDebug("Saving file...");
            _azureFile.SaveFileAsync(file);

            _logger.LogDebug("File saved!");

            return Ok();
        }
    }
}
