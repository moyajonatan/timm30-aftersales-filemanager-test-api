using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
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
                .SetConfigurations(GetListOptions(fileTypeEnum))
                .Build();
            var isValid = fileProcessor.Validate();
            return Ok(isValid);
        }

        private List<ProcessorOption> GetListOptions(FileTypeEnum fileTypeEnum)
        {
            return fileTypeEnum switch
            {
                FileTypeEnum.PricesListAutoma => GetAutomaOptions(),
                FileTypeEnum.OfferListGm => GetOfferGmOptions(),
                _ => GetAutomaOptions(),
            };
        }

        private List<ProcessorOption> GetAutomaOptions()
        {
            var options = new List<ProcessorOption>
            {
                new HeaderOption
                {
                    IndexEnd = 11
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Descripción del Articulo
                    Format = "[A-Za-z0-9\\s]",
                    Index = 1,
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Modelo
                    Format = "[A-Za-z0-9\\s]",
                    Index = 3,
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Categoría
                    Index = 4,
                },
                 new IndexedColumnOption
                {
                    DataType = "string", //Compatibilidad
                    Index = 5,
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Nuevo Código
                    Format = "^([A-Z0-9]{12}|-)$",
                    Index = 6,
                },
                new IndexedColumnOption
                {
                    DataType = "decimal", //Lista de Precio
                    Index = 7,
                },
                new IndexedColumnOption
                {
                    DataType = "decimal",
                    Index = 8, //dto com
                },
                new IndexedColumnOption
                {
                    DataType = "decimal",
                    Index = 9, //dto fin
                },
                new IndexedColumnOption
                {
                    DataType = "decimal",
                    Index = 10, //costo maipú
                },
                new IndexedColumnOption
                {
                    DataType = "decimal",
                    Index = 14, //precio sin iva
                },
                new IndexedColumnOption
                {
                    DataType = "decimal",
                    Index = 15, //precio con iva
                },
            };

            return options;
        }

        private List<ProcessorOption> GetOfferGmOptions()
        {
            var options = new List<ProcessorOption> {
                new HeaderOption
                {
                    IndexEnd = 7,
                    Page = 3
                },
                 new IndexedColumnOption
                {
                    DataType = "string", //Linea
                    Format = "[A-Za-z\\s]",
                    Index = 2,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Numero de Pieza
                    Format = "^[0-9]+$",
                    Index = 3,
                    Page = 3
                },
            };

            return options;
        }
    }
}
