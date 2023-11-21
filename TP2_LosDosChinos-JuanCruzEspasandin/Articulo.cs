using FluentValidation;
using FluentValidation.Results;
using Microsoft.Win32;
using SchemaUser;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TP2_LosDosChinos_JuanCruzEspasandin.Controladores;

namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    public class Articulo
    {
        public Articulo(long articuloID, string detalle, string presentacion, int precioCompra, int precioVenta, int stock)
        {
            ArticuloID = articuloID;
            Detalle = detalle;
            Presentacion = presentacion;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Stock = stock;
        }

        public long ArticuloID { get; set; }
        public string Detalle { get; set; }
        public string Presentacion { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }

        public ValidationResult Validar(Articulo articulo)
        {
            var articuloValidator = new ArticuloValidator();
            ValidationResult result = articuloValidator.Validate(articulo);
            return result;
        }

        public class ArticuloValidator : AbstractValidator<Articulo>
        {
            public ArticuloValidator()
            {
                RuleFor(x => x.ArticuloID)
                    .NotEmpty().WithMessage("El ID del artículo es obligatorio.")
                    .Must(id => id.ToString().Length == 13).WithMessage("El ID del artículo debe tener exactamente 13 dígitos.");

                RuleFor(x => x.Detalle)
                    .NotEmpty().WithMessage("El detalle del artículo es obligatorio.")
                    .MaximumLength(255).WithMessage("El detalle del artículo no puede tener más de 255 caracteres.");

                RuleFor(x => x.Presentacion)
                    .NotEmpty().WithMessage("La presentación del artículo es obligatoria.")
                    .MaximumLength(255).WithMessage("La presentación del artículo no puede tener más de 255 caracteres.");

                RuleFor(x => x.PrecioCompra)
                    .GreaterThanOrEqualTo(0).WithMessage("El precio de compra debe ser mayor o igual a cero.");

                RuleFor(x => x.PrecioVenta)
                    .GreaterThanOrEqualTo(0).WithMessage("El precio de venta debe ser mayor o igual a cero.");

                RuleFor(x => x.Stock)
                    .GreaterThanOrEqualTo(0).WithMessage("El stock del artículo debe ser mayor o igual a cero.");
            }
        }
    }
}