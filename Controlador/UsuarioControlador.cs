using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
namespace Controlador
{
    public class UsuarioControlador
    {
        public Modelo.Usuario usuario { get; set; }
        public Modelo.Usuario obtenerUsuario(Usuario user)
        {
            AccesoDatos Conexion = new AccesoDatos();
            try
            {
                Conexion.conectar();
                Conexion.setearConsulta("SELECT c.[id],c.[usuario], c.[contra], c.[rol] FROM [Resto].[dbo].[usuarios] AS c WITH (NOLOCK);");
                Conexion.ejecutarLectura();

                while (Conexion.Lector.Read())
                {
                    usuario = new Usuario();
                    usuario.id = (int)Conexion.Lector["id"];
                    usuario.usuario = (string)Conexion.Lector["usuario"];
                    usuario.contra = (string)Conexion.Lector["contra"];
                    usuario.rol = (int)Conexion.Lector["rol"];
                    if (user != null)
                    {
                        if (user.usuario == usuario.usuario && user.contra == usuario.contra)
                        {
                            return usuario;
                        }

                    }
                }
                return usuario;
            }
            catch (Exception excepcion)
            {
                throw excepcion;

            }
            finally
            {
                Conexion.cerrar();
            }
            
        }
        public bool iniciarSesion(Usuario user)
        {

            AccesoDatos Conexion = new AccesoDatos();
            try
            {
                Conexion.conectar();
                Conexion.setearConsulta("SELECT c.[usuario], c.[contra] FROM [Resto].[dbo].[usuarios] AS c WITH (NOLOCK);");
                Conexion.ejecutarLectura();

                while (Conexion.Lector.Read())
                {
                    usuario = new Usuario();
                    usuario.usuario = (string)Conexion.Lector["usuario"];
                    usuario.contra = (string)Conexion.Lector["contra"];
                    if (user != null)
                    {
                        if (user.usuario == usuario.usuario && user.contra == usuario.contra)
                        {
                            return true;
                        }

                    }
                }
                return false;
            }
            catch (Exception excepcion)
            {
                throw excepcion;
                
            }
            finally
            {
                Conexion.cerrar();
            }
        }
    }
}
