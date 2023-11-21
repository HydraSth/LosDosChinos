using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using TP2_LosDosChinos_JuanCruzEspasandin;

namespace SchemaUser
{
    public class User
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }

        public int Acceso = 1;

        public ValidationResult Validar(User usuario)
        {
            var userValidator = new UserValidator();
            ValidationResult result = userValidator.Validate(usuario);
            return result;
        }

        public class UserValidator : AbstractValidator<User>
        {
            public UserValidator()
            {
                RuleFor(x => x.Usuario)
                     .NotEmpty().WithMessage("El nombre de usuario es obligatorio.")
                     .MinimumLength(3).WithMessage("El nombre de usuario debe tener al menos 3 caracteres.")
                     .MaximumLength(15).WithMessage("El nombre de usuario no puede tener más de 15 caracteres.");

                RuleFor(x => x.Contraseña)
                    .NotEmpty().WithMessage("La contraseña es obligatoria.")
                    .MinimumLength(6).WithMessage("La contraseña debe tener al menos 6 caracteres.");

                RuleFor(x => x.Nombre)
                    .NotEmpty().WithMessage("El nombre es obligatorio.")
                    .MinimumLength(3).WithMessage("El nombre debe tener al menos 3 caracteres.")
                    .MaximumLength(15).WithMessage("El nombre no puede tener más de 15 caracteres.");

                RuleFor(x => x.Apellido)
                    .NotEmpty().WithMessage("El apellido es obligatorio.")
                    .MinimumLength(3).WithMessage("El apellido debe tener al menos 3 caracteres.")
                    .MaximumLength(15).WithMessage("El apellido no puede tener más de 15 caracteres.");

                RuleFor(x => x.CorreoElectronico)
                    .NotEmpty().WithMessage("El correo electrónico es obligatorio.")
                    .EmailAddress().WithMessage("El correo electrónico no tiene un formato válido.");

                RuleFor(x => x.Telefono)
                    .NotEmpty().WithMessage("El número de teléfono es obligatorio.")
                    .Matches(@"^\d{10}$").WithMessage("El número de teléfono debe tener 10 dígitos numéricos.");
            }
        }

        public User()
        {
        }

        public User(string usuario, string contraseña, string nombre, string apellido, string correoElectronico, string telefono)
        {
            Usuario = usuario;
            Contraseña = contraseña;
            Nombre = nombre;
            Apellido = apellido;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
        }

        public bool Rango()
        {
            return Acceso == 1;
        }

        public User CompletarUser(string usuarioId)
        {
            var Conexion = new ControladorDB();
            var response = Conexion.GetUser(Conexion, usuarioId);
            Nombre = response.Nombre;
            Usuario = response.Usuario;
            CorreoElectronico = response.CorreoElectronico;
            Telefono = response.Telefono;
            if (response.Acceso == 0)
            {
                Acceso = 1;
            }
            else
            {
                Acceso = 0;
            }
            return this;
        }

        public void VerUser()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Usuario: " + Usuario);
            Console.WriteLine("Correo electrónico: " + CorreoElectronico);
            Console.WriteLine("Telefono: " + Telefono);
            Console.WriteLine("Acceso: " + Acceso);
        }
    }
}