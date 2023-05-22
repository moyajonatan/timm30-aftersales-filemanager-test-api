using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Timm30.AfterSale.Test.Api.Factory;
using Timm30.AfterSales.FileProcessingService.Lib.Builders.IBuilders;
using Timm30.AfterSales.FileProcessingService.Lib.Enums;
using Timm30.AfterSales.FileProcessingService.Lib.Models;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileProcessorBuilder fileProcessorBuilder;

        public FileController(IFileProcessorBuilder _fileProcessorBuilder)
        {
            this.fileProcessorBuilder = _fileProcessorBuilder;
        }

        [HttpPost(Name = "Post")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Post(IFormFile file, FileTypeEnum fileTypeEnum)
        {
            if (file == null || file.Length == 0)
                return Content("file not selected");

            var fileName = file.FileName;
            var stream = file.OpenReadStream();

            var fileProcessor = fileProcessorBuilder
                .SetFile(stream, fileName)
                .SetFileTypeEnum(fileTypeEnum)
                .SetConfigurations(OptionsFactory.GetListOptions(fileTypeEnum))
                .Build();
            var isValid = fileProcessor.Validate();
            return Ok(isValid);
        }
    }
}
