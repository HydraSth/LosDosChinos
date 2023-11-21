using SchemaUser;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_LosDosChinos_JuanCruzEspasandin.Controladores;
using TP2_LosDosChinos_JuanCruzEspasandin.src;

namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    public class ControladorDB
    {
        public string ConnectionString { get; set; }

        public ControladorDB()
        {
            this.ConnectionString = "Server=JR5;Database=LosDosChinosDB; Trusted_Connection=True;TrustServerCertificate=True";
        }

        public static string AgregarUsuario(ControladorDB controladorDb, User usuario)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDb.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = $"SELECT * FROM Usuarios WHERE Usuario='{usuario.Usuario}' OR CorreoElectronico='{usuario.CorreoElectronico}'";
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return "El nombre de usuario ya existe o el correo electronico esta en uso";
                    }
                    else
                    {
                        reader.Close();
                        sqlCommand.CommandText = "INSERT INTO Usuarios" +
                            "(Usuario,Contraseña,NombreCompleto,CorreoElectronico,Telefono,Acceso)" +
                            "Values(@usuario,@contraseña,@nombre,@correo,@telefono,@acceso)";
                        sqlCommand.Parameters.AddWithValue("@usuario", usuario.Usuario);
                        sqlCommand.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                        sqlCommand.Parameters.AddWithValue("@nombre", $"{usuario.Nombre} {usuario.Apellido}");
                        sqlCommand.Parameters.AddWithValue("@correo", usuario.CorreoElectronico);
                        sqlCommand.Parameters.AddWithValue("@telefono", usuario.Telefono);
                        sqlCommand.Parameters.AddWithValue("@acceso", usuario.Acceso);
                        sqlCommand.ExecuteNonQuery();
                        return "Usuario creado con exito";
                    }
                }
            }
        }

        public string Login(ControladorDB controladorDB, string usuario, string contraseña)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = $"SELECT * FROM Usuarios WHERE Usuario='{usuario}' AND Contraseña='{contraseña}'";
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return "Inicio de sesión exitoso";
                        }
                        else
                        {
                            return "Inicio de sesión fallido";
                        }
                    }
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public bool UpdateUser(ControladorDB controladorDB, string nombre, string usuario, string email, string telefono)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "UPDATE Usuarios SET NombreCompleto=@nombre, CorreoElectronico=@email, telefono=@telefono WHERE Usuario=@usuario";

                    sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                    sqlCommand.Parameters.AddWithValue("@email", email);
                    sqlCommand.Parameters.AddWithValue("@telefono", telefono);
                    sqlCommand.Parameters.AddWithValue("@usuario", usuario);

                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    return rowsAffected > 0; // Devuelve verdadero si se actualizaron filas, falso en caso contrario.
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return false;
                }
            }
        }

        public User GetUser(ControladorDB controladorDB, string usuario)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = $"SELECT * FROM Usuarios WHERE Usuario='{usuario}'";
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User usuarioSeleccionado = new User();
                            usuarioSeleccionado.Usuario = reader.GetString(1);
                            usuarioSeleccionado.Contraseña = reader.GetString(2);
                            usuarioSeleccionado.Nombre = reader.GetString(3);
                            usuarioSeleccionado.CorreoElectronico = reader.GetString(4);
                            usuarioSeleccionado.Telefono = reader.GetString(5);
                            usuarioSeleccionado.Acceso = reader.GetInt32(6);
                            return usuarioSeleccionado;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return null;
                }
            }
        }

        public List<User> GetUsuarios(ControladorDB controladorDB)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * FROM Usuarios";
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        List<User> usuarios = new List<User>();
                        while (reader.Read())
                        {
                            User usuario = new User();
                            usuario.Usuario = reader.GetString(1);
                            usuario.Contraseña = reader.GetString(2);
                            usuario.Nombre = reader.GetString(3);
                            usuario.CorreoElectronico = reader.GetString(4);
                            usuario.Telefono = reader.GetString(5);
                            usuario.Acceso = reader.GetInt32(6);
                            usuarios.Add(usuario);
                        }
                        return usuarios;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return null;
                }
            }
        }

        public void CloseSesion(ControladorDB controladorDb, Sesion SesionActual)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDb.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "INSERT INTO Sesion (SesionId, UsuarioId, Fecha, HoraInicio, HoraFin) " +
                                           "Values(@sesionId, @usuarioId, @fecha, @horaInicio, @horaFin)";
                    sqlCommand.Parameters.AddWithValue("@sesionId", SesionActual.SesionId);
                    sqlCommand.Parameters.AddWithValue("@usuarioId", SesionActual.UsuarioId);
                    sqlCommand.Parameters.AddWithValue("@fecha", SesionActual.Fecha);
                    sqlCommand.Parameters.AddWithValue("@horaInicio", SesionActual.HoraInicio);
                    sqlCommand.Parameters.AddWithValue("@horaFin", SesionActual.HoraFin);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    // Manejo de errores
                }
            }
        }

        public List<Articulo> GetArticulos(ControladorDB controladorDB)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Articulos";
                List<Articulo> articulos = new List<Articulo>();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Accede a cada columna por su nombre o índice y crea un nuevo objeto Articulo
                        long articuloID = reader.GetInt64(reader.GetOrdinal("ArticuloID"));
                        string detalle = reader.GetString(reader.GetOrdinal("Detalle"));
                        string presentacion = reader.GetString(reader.GetOrdinal("Presentacion"));
                        int precioCompra = reader.GetInt32(reader.GetOrdinal("PrecioCompra"));
                        int precioVenta = reader.GetInt32(reader.GetOrdinal("PrecioVenta"));
                        int stock = reader.GetInt32(reader.GetOrdinal("Stock"));
                        // Crea un nuevo objeto Articulo y agrégalo a la lista
                        Articulo articulo = new Articulo(articuloID, detalle, presentacion, precioCompra, precioVenta, stock);
                        articulos.Add(articulo);
                    }
                    sqlConnection.Close();
                }
                return articulos;
            }
        }

        public Articulo GetArticulo(ControladorDB controladorDB, string IDABuscar)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = $"Select * from Articulos where ArticuloId='{IDABuscar}'";
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        long articuloID = reader.GetInt64(reader.GetOrdinal("ArticuloID"));
                        string detalle = reader.GetString(reader.GetOrdinal("Detalle"));
                        string presentacion = reader.GetString(reader.GetOrdinal("Presentacion"));
                        int precioCompra = reader.GetInt32(reader.GetOrdinal("PrecioCompra"));
                        int precioVenta = reader.GetInt32(reader.GetOrdinal("PrecioVenta"));
                        int stock = reader.GetInt32(reader.GetOrdinal("Stock"));
                        Articulo articulo = new Articulo(articuloID, detalle, presentacion, precioCompra, precioVenta, stock);
                        return articulo;
                    }
                }
                return null;
            }
        }

        public bool ExisteArticulo(ControladorDB controladorDB, string IDABuscar)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = $"Select * from Articulos where ArticuloId='{IDABuscar}'";
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool AddArticulo(ControladorDB controladorDB, Articulo articulo)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "INSERT INTO Articulos (ArticuloID, Detalle, Presentacion, PrecioCompra, PrecioVenta, Stock) " +
                    "Values(@articuloID, @detalle, @presentacion, @precioCompra, @precioVenta, @stock)";
                    sqlCommand.Parameters.AddWithValue("@articuloID", articulo.ArticuloID);
                    sqlCommand.Parameters.AddWithValue("@detalle", articulo.Detalle);
                    sqlCommand.Parameters.AddWithValue("@presentacion", articulo.Presentacion);
                    sqlCommand.Parameters.AddWithValue("@precioCompra", articulo.PrecioCompra);
                    sqlCommand.Parameters.AddWithValue("@precioVenta", articulo.PrecioVenta);
                    sqlCommand.Parameters.AddWithValue("@stock", articulo.Stock);
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public void ModificarArticulo(ControladorDB controladorDB, Articulo articulo)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "UPDATE Articulos SET Detalle=@detalle, Presentacion=@presentacion, PrecioCompra=@precioCompra, PrecioVenta=@precioVenta, Stock=@stock WHERE ArticuloID=@articuloID";
                    sqlCommand.Parameters.AddWithValue("@articuloID", articulo.ArticuloID);
                    sqlCommand.Parameters.AddWithValue("@detalle", articulo.Detalle);
                    sqlCommand.Parameters.AddWithValue("@presentacion", articulo.Presentacion);
                    sqlCommand.Parameters.AddWithValue("@precioCompra", articulo.PrecioCompra);
                    sqlCommand.Parameters.AddWithValue("@precioVenta", articulo.PrecioVenta);
                    sqlCommand.Parameters.AddWithValue("@stock", articulo.Stock);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public void EliminarArticulo(ControladorDB controladorDB, string ID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "DELETE FROM Articulos WHERE ArticuloID=@articuloID";
                    sqlCommand.Parameters.AddWithValue("@articuloID", ID);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public void RealizarVenta(ControladorDB controladorDB, string ID, int Cantidad)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "UPDATE Articulos SET Stock = Stock - @cantidad WHERE ArticuloID = @articuloID";
                    sqlCommand.Parameters.AddWithValue("@articuloID", ID);
                    sqlCommand.Parameters.AddWithValue("@cantidad", Cantidad);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public List<Articulo> GetFilterArticulos(ControladorDB controladorDB, long id, string detalle)
        {
            var articulos = new List<Articulo>();
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                if (id != 0)
                {
                    if (!string.IsNullOrEmpty(detalle))
                    {
                        // Utiliza parámetros para evitar problemas de SQL Injection
                        sqlCommand.CommandText = "SELECT * FROM Articulos WHERE ArticuloID = @id AND Detalle = @detalle";
                        sqlCommand.Parameters.AddWithValue("@id", id);
                        sqlCommand.Parameters.AddWithValue("@detalle", detalle);
                    }
                    else
                    {
                        sqlCommand.CommandText = "SELECT * FROM Articulos WHERE ArticuloID = @id";
                        sqlCommand.Parameters.AddWithValue("@id", id);
                    }
                }
                else
                {
                    // Utiliza parámetros para evitar problemas de SQL Injection
                    sqlCommand.CommandText = "SELECT * FROM Articulos WHERE Detalle = @detalle";
                    sqlCommand.Parameters.AddWithValue("@detalle", detalle);
                }

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long articuloID = reader.GetInt64(reader.GetOrdinal("ArticuloID"));
                        string detalleProd = reader.GetString(reader.GetOrdinal("Detalle"));
                        string presentacion = reader.GetString(reader.GetOrdinal("Presentacion"));
                        int precioCompra = reader.GetInt32(reader.GetOrdinal("PrecioCompra"));
                        int precioVenta = reader.GetInt32(reader.GetOrdinal("PrecioVenta"));
                        int stock = reader.GetInt32(reader.GetOrdinal("Stock"));
                        articulos.Add(new Articulo(articuloID, detalleProd, presentacion, precioCompra, precioVenta, stock));
                    }
                }
            }
            return articulos;
        }

        public bool AddProveedor(ControladorDB controladorDB, Proveedor proveedor)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Proveedores (ProveedorId, Nombre, CUIT, Email, Celular, Rubro, Direccion) VALUES (@ProveedorId, @Nombre, @CUIT, @Email, @Celular, @Rubro, @Direccion)", sqlConnection))
                    {
                        // Suponiendo que tienes un objeto Proveedor llamado proveedor con las propiedades correspondientes
                        sqlCommand.Parameters.AddWithValue("@ProveedorId", proveedor.ProveedorId);
                        sqlCommand.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                        sqlCommand.Parameters.AddWithValue("@CUIT", proveedor.CUIT);
                        sqlCommand.Parameters.AddWithValue("@Email", proveedor.Email);
                        sqlCommand.Parameters.AddWithValue("@Celular", proveedor.Celular);
                        sqlCommand.Parameters.AddWithValue("@Rubro", proveedor.Rubro);
                        sqlCommand.Parameters.AddWithValue("@Direccion", proveedor.Direccion);

                        // Ejecutar el comando
                        sqlCommand.ExecuteNonQuery();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List<Proveedor> GetProveedores(ControladorDB controladorDB)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Proveedores";
                List<Proveedor> proveedores = new List<Proveedor>();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int proveedorId = reader.GetInt32(reader.GetOrdinal("ProveedorId"));
                        string nombre = reader.GetString(reader.GetOrdinal("Nombre"));
                        string CUIT = reader.GetString(reader.GetOrdinal("CUIT"));
                        string email = reader.GetString(reader.GetOrdinal("Email"));
                        string celular = reader.GetString(reader.GetOrdinal("Celular"));
                        string rubro = reader.GetString(reader.GetOrdinal("Rubro"));
                        string direccion = reader.GetString(reader.GetOrdinal("Direccion"));

                        // Crea un nuevo objeto Articulo y agrégalo a la lista
                        Proveedor proveedorToPush = new Proveedor(proveedorId, nombre, CUIT, email, celular, rubro, direccion);
                        proveedores.Add(proveedorToPush);
                    }
                    sqlConnection.Close();
                }
                return proveedores;
            }
        }

        public void EliminarProveedor(ControladorDB controladorDB, string ID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "DELETE FROM Proveedores WHERE Nombre=@articuloID";
                    sqlCommand.Parameters.AddWithValue("@articuloID", ID);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public bool ExisteProveedor(ControladorDB controladorDB, string IDABuscar)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = $"Select * from Proveedores where Nombre='{IDABuscar}'";
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool ModificarProveedor(ControladorDB controladorDB, Proveedor proveedor)
        {
            using (SqlConnection sqlConnection = new SqlConnection(controladorDB.ConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("UPDATE Proveedores SET CUIT=@CUIT, Email=@Email, Celular=@Celular, Rubro=@Rubro, Direccion=@Direccion WHERE Nombre=@Nombre", sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                        sqlCommand.Parameters.AddWithValue("@CUIT", proveedor.CUIT);
                        sqlCommand.Parameters.AddWithValue("@Email", proveedor.Email);
                        sqlCommand.Parameters.AddWithValue("@Celular", proveedor.Celular);
                        sqlCommand.Parameters.AddWithValue("@Rubro", proveedor.Rubro);
                        sqlCommand.Parameters.AddWithValue("@Direccion", proveedor.Direccion);

                        sqlCommand.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return false;
                }
            }
        }
    }
}