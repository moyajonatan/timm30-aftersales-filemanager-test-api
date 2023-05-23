using Timm30.AfterSales.FileProcessingService.Lib.Enums;
using Timm30.AfterSales.FileProcessingService.Lib.Models;

namespace Timm30.AfterSale.Test.Api.Factory
{
    public static class OptionsFactory
    {
        private static List<ProcessorOption> GetAutomaOptions()
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

        private static List<ProcessorOption> GetOfferGmOptions()
        {
            var options = new List<ProcessorOption> {
                new HeaderOption
                {
                    IndexEnd = 6,
                    Page = 2
                },

                new IndexedColumnOption
                {
                    DataType = "int", //Total de Items
                    Index = 4,
                    Page = 2
                },
                //lote 1
                new IndexedColumnOption
                {
                    DataType = "string", //Volumen
                    Format = "^\\d+\\s*a\\s*\\d+$",
                    Index = 5,
                    Page = 2
                },

                new IndexedColumnOption
                {
                    DataType = "decimal", //Descuento  
                    Index = 6,
                    Page = 2
                },
                //lote 2
                new IndexedColumnOption
                {
                    DataType = "string", //Volumen
                    Format = "^\\d+\\s*a\\s*\\d+$",
                    Index = 7,
                    Page = 2
                },

                new IndexedColumnOption
                {
                    DataType = "decimal", //Descuento  
                    Index = 8,
                    Page = 2
                },
                //lote 3
                new IndexedColumnOption
                {
                    DataType = "string", //Volumen
                    Format = "^\\d+\\s*a\\s*\\d+$",
                    Index = 9,
                    Page = 2
                },

                new IndexedColumnOption
                {
                    DataType = "decimal", //Descuento  
                    Index = 10,
                    Page = 2
                },
                //lote 4
                new IndexedColumnOption
                {
                    DataType = "string", //Volumen Mínimo  
                    Format = "^(?:\\d+)?$",
                    Index = 11,
                    Page = 2
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Volumen Mínimo
                    Index = 12,
                    Page = 2
                },

                new HeaderOption
                {
                    IndexEnd = 7,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Linea
                    Format = "^[a-zA-Z\\s-]+$",
                    Index = 2,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Numero de Pieza
                    Format = "^[a-zA-Z0-9\\s]+$",
                    Index = 3,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Numero de Pieza de Reemplazo
                    Format = "^[a-zA-Z0-9\\s]*$",
                    Index = 5,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Unidades por envase
                    Format = "^[0-9]+$",
                    Index = 6,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Código de lote
                    Format = "^[A-Z][0-9]{2}$",
                    Index = 7,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Nombre
                    Index = 8,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Aplicación
                    Index = 9,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "decimal?", //Precio de Lote 1
                    Index = 10,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "decimal?", //Precio de Lote 2
                    Index = 11,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "decimal?", //Precio de Lote 3
                    Index = 12,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "decimal?", //Precio de Lote 4
                    Index = 13,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "decimal?", //Descuento de Lote 1
                    Index = 14,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "decimal?", //Descuento de Lote 2
                    Index = 15,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "decimal?", //Descuento de Lote 3
                    Index = 16,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "decimal?", //Descuento de Lote 4
                    Index = 17,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "decimal", //Precio de venta al público
                    Index = 18,
                    Page = 3
                },
                new IndexedColumnOption
                {
                    DataType = "string", //Observaciones
                    Index = 19,
                    Page = 3
                }
            };

            return options;
        }

        private static List<ProcessorOption> GetVwPriceOptions()
        {
            var options = new List<ProcessorOption> {
                new TextFieldColumnOption
                {
                    DataType = "string", //Referencia de fabrica
                    Format = "^[A-Za-z0-9]+$",
                    IndexStart = 0,
                    Length = 4
                },
                new TextFieldColumnOption
                {
                    DataType = "string", //Numero de pieza
                    Format =  @"^[A-Za-z0-9\s-]+$",
                    IndexStart = 5,
                    Length = 20,
                },
                new TextFieldColumnOption
                {
                    DataType = "decimal", //Precio sin IVA
                    IndexStart = 25,
                    Length = 11
                },
                 new TextFieldColumnOption
                {
                    DataType = "string", //Codigo descuento
                    Format = @"[A-Za-z0-9]*$",
                    IndexStart = 36,
                    Length = 4
                },
                new TextFieldColumnOption
                {
                    DataType = "int", //Unidades por envase
                    IndexStart = 40,
                    Length = 7
                },
                new TextFieldColumnOption
                {
                    DataType = "string", //Nombre
                    Format = @"^[A-Za-z0-9\s\.]+$",
                    IndexStart = 47,
                    Length = 25
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Unidad de cambio
                    Format = "^[A-Za-z0-9]*$",
                    IndexStart = 72,
                    Length = 3
                },
                new TextFieldColumnOption
                {
                    DataType = "int", // Fecha de baja
                    IndexStart = 75,
                    Length = 7
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Codigo de cambio
                    Format = "^[A-Za-z0-9]*$",
                    IndexStart = 82,
                    Length = 1
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Numero de pieza reemp
                    Format = "^[A-Za-z0-9-]*$",
                    IndexStart = 84,
                    Length = 20
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Nombre pieza reemp
                    Format = "^[A-Za-z0-9]*$",
                    IndexStart = 104,
                    Length = 25
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Numero de lista
                    Format = "^[A-Za-z0-9]+$",
                    IndexStart = 129,
                    Length = 2
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Codigo IVA
                    Format = "^[A-Za-z0-9]+$",
                    IndexStart = 131,
                    Length = 1
                },
                new TextFieldColumnOption
                {
                    DataType = "int", // Codigo margen
                    IndexStart = 132,
                    Length = 1
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Clasificacion
                    Format = "^[A-Za-z0-9]+$",
                    IndexStart = 133,
                    Length = 3
                },
                new TextFieldColumnOption
                {
                    DataType = "decimal", // Porcentaje IVA
                    IndexStart = 136,
                    Length = 5
                },
                new TextFieldColumnOption
                {
                    DataType = "decimal", // Precio con IVA
                    IndexStart = 141,
                    Length = 11
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Grupo pieza
                    Format = "[A-Za-z0-9]+",
                    IndexStart = 152,
                    Length = 1
                }
            };
            return options;
        }

        private static List<ProcessorOption> GetFordPriceOptions()
        {
            var options = new List<ProcessorOption> {
                new TextFieldColumnOption
                {
                    DataType = "string", //Referencia de fabrica
                    Format = "^[A-Za-z0-9]+$",
                    IndexStart = 0,
                    Length = 4
                },
                new TextFieldColumnOption
                {
                    DataType = "string", //Numero de pieza
                    Format =  @"^[A-Za-z0-9\s/]+$",
                    IndexStart = 5,
                    Length = 20,
                },
                new TextFieldColumnOption
                {
                    DataType = "decimal", //Precio sin IVA
                    IndexStart = 25,
                    Length = 11
                },
                 new TextFieldColumnOption
                {
                    DataType = "string", //Codigo descuento
                    Format = "^[A-Za-z0-9]+$",
                    IndexStart = 36,
                    Length = 4
                },
                new TextFieldColumnOption
                {
                    DataType = "int", //Unidades por envase
                    IndexStart = 40,
                    Length = 7
                },
                new TextFieldColumnOption
                {
                    DataType = "string", //Nombre
                    Format = @"^.+$",
                    IndexStart = 47,
                    Length = 25
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Unidad de cambio
                    Format = "^[A-Za-z0-9]*$",
                    IndexStart = 72,
                    Length = 3
                },
                new TextFieldColumnOption
                {
                    DataType = "int", // Fecha de baja
                    IndexStart = 75,
                    Length = 7
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Codigo de cambio
                    Format = "^[A-Za-z0-9]*$",
                    IndexStart = 82,
                    Length = 1
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Numero de pieza reemp
                    Format = @"^[A-Za-z0-9/\s]*$",
                    IndexStart = 84,
                    Length = 20
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Nombre pieza reemp
                    Format = @"^.+$",
                    IndexStart = 104,
                    Length = 25
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Numero de lista
                    Format = "^[A-Za-z0-9]+$",
                    IndexStart = 129,
                    Length = 2
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Codigo IVA
                    Format = "^[A-Za-z0-9]+$",
                    IndexStart = 131,
                    Length = 1
                },
                new TextFieldColumnOption
                {
                    DataType = "int", // Codigo margen
                    IndexStart = 132,
                    Length = 1
                },
                new TextFieldColumnOption
                {
                    DataType = "string", // Clasificacion
                    Format = "^[A-Za-z0-9]+$",
                    IndexStart = 133,
                    Length = 3
                },
                new TextFieldColumnOption
                {
                    DataType = "decimal", // Porcentaje IVA
                    IndexStart = 136,
                    Length = 5
                },
            };
            return options;
        }

        private static List<ProcessorOption> GetGmPriceOptions()
        {
            var options = new List<ProcessorOption>
            {
                new HeaderOption
                {
                    IndexEnd = 1
                },
                new TextFieldColumnOption
                {
                    DataType = "string", //Articulo
                    Format = @"^[A-Za-z0-9]+$",
                    IndexStart = 0,
                    Length = 16
                },
                new TextFieldColumnOption
                {
                    DataType = "string", //Descripcion
                    Format =  @"^.+$",
                    IndexStart = 17,
                    Length = 30,
                },
                new TextFieldColumnOption
                {
                    DataType = "int", //Cant x empaque
                    IndexStart = 48,
                    Length = 4
                },
                 new TextFieldColumnOption
                {
                    DataType = "string", //Numero pieza reemplazo
                    Format = @"^\w*$",
                    IndexStart = 53,
                    Length = 16
                },
                new TextFieldColumnOption
                {
                    DataType = "string", //Porcentaje Descuento
                    Format = @"^\d{2},\d{2}$",
                    IndexStart = 70,
                    Length = 5
                },
                new TextFieldColumnOption
                {
                    DataType = "string", //Precio Venta
                    Format = @"^\d+,\d{2}$",
                    IndexStart = 76,
                    Length = 10
                },
            };

            return options;
        }

        public static List<ProcessorOption> GetListOptions(FileTypeEnum fileTypeEnum)
        {
            return fileTypeEnum switch
            {
                FileTypeEnum.PricesList_Automa => GetAutomaOptions(),
                FileTypeEnum.OfferList_Gm => GetOfferGmOptions(),
                FileTypeEnum.PricesList_Gm => GetGmPriceOptions(),
                FileTypeEnum.PricesList_Vw => GetVwPriceOptions(),
                FileTypeEnum.PricesList_Ford => GetFordPriceOptions(),
                _ => GetAutomaOptions(),
            };
        }
    }

}
