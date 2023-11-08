using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebService_ProximaGen.Base
{
    public class Procedures : BaseDatos
    {
        public DataSet CUD_Estados(int modo, int idEstado, string descripcionEstado)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("CUD_Estados");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@modo", modo);
                sqlCommand.Parameters.AddWithValue("@idEstado", idEstado);
                sqlCommand.Parameters.AddWithValue("@descripcionEstado", descripcionEstado);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet Read_Estados(int inicio, int final)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("Read_Estados");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@inicio", inicio);
                sqlCommand.Parameters.AddWithValue("@final", final);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet CUD_Tipo_Contactos(int modo, int idTipoContacto, string descripcionTipoContacto)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("CUD_Tipo_Contactos");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@modo", modo);
                sqlCommand.Parameters.AddWithValue("@idTipoContacto", idTipoContacto);
                sqlCommand.Parameters.AddWithValue("@descripcionTipoContacto", descripcionTipoContacto);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }


        public DataSet Read_Tipo_Contactos(int inicio, int final)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("Read_Tipo_Contactos");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@inicio", inicio);
                sqlCommand.Parameters.AddWithValue("@final", final);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet CUD_Roles(int modo, int idRol, string descripcionRol)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("CUD_Roles");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@modo", modo);
                sqlCommand.Parameters.AddWithValue("@idRol", idRol);
                sqlCommand.Parameters.AddWithValue("@descripcionRol", descripcionRol);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet Read_Roles(int inicio, int final)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("Read_Roles");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@inicio", inicio);
                sqlCommand.Parameters.AddWithValue("@final", final);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet CUD_Generos(int modo, int idGenero, string genero)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("CUD_Generos");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@modo", modo);
                sqlCommand.Parameters.AddWithValue("@idGenero", idGenero);
                sqlCommand.Parameters.AddWithValue("@genero", genero);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet Read_Generos(int inicio, int final)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("Read_Generos");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@inicio", inicio);
                sqlCommand.Parameters.AddWithValue("@final", final);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet CUD_AsignarPermisoXRol(int modo, int idPermiso, int idRol)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("CUD_AsignarPermisosARol");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@modo", modo);
                sqlCommand.Parameters.AddWithValue("@idPermiso", idPermiso);
                sqlCommand.Parameters.AddWithValue("@idRol", idRol);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet CUD_Permisos(int modo, int idPermiso, string permiso)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("CUD_Permisos");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@modo", modo);
                sqlCommand.Parameters.AddWithValue("@idPermiso", idPermiso);
                sqlCommand.Parameters.AddWithValue("@permiso", permiso);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }
        public DataSet Read_Permisos(int inicio, int final)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("Read_Permisos");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@inicio", inicio);
                sqlCommand.Parameters.AddWithValue("@final", final);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }
        public DataSet Read_PermisosXRol(int idRol)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("Read_PermisosXRol");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@idRol", idRol);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet CUD_Contactos(int modo, int idContacto, string descripcionContacto, int TipoContactos_idTipoContacto, int Personas_idPersona)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("CUD_Contactos");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@modo", modo);
                sqlCommand.Parameters.AddWithValue("@idContacto", idContacto);
                sqlCommand.Parameters.AddWithValue("@descripcionContacto", descripcionContacto);
                sqlCommand.Parameters.AddWithValue("@TipoContactos_idTipoContacto ", TipoContactos_idTipoContacto);
                sqlCommand.Parameters.AddWithValue("@Personas_idPersona", Personas_idPersona);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet Read_ContactoXPersona(int idPersona)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("Read_ContactoXPersona");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@idPersona", idPersona);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet CUD_Tarjetas(int modo, int idTarjeta, string numeroTarjeta, int expiracionMes, int expiracionAnno, string cvv, int Personas_idPersona, int Estados_idEstado)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("CUD_Tarjetas");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@modo", modo);
                sqlCommand.Parameters.AddWithValue("@idTarjeta", idTarjeta);
                sqlCommand.Parameters.AddWithValue("@numeroTarjeta", numeroTarjeta);
                sqlCommand.Parameters.AddWithValue("@expiracionMes ", expiracionMes);
                sqlCommand.Parameters.AddWithValue("@expiracionAnno", expiracionAnno);
                sqlCommand.Parameters.AddWithValue("@cvv", cvv);
                sqlCommand.Parameters.AddWithValue("@Personas_idPersona", Personas_idPersona);
                sqlCommand.Parameters.AddWithValue("@Estados_idEstado", Estados_idEstado);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet Read_TarjetaXPersona(int idPersona)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("Read_TarjetaXPersona");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@idPersona", idPersona);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet CUDPersonaContactoUsuario(int modo, int cedula, string nombre, string apellido, string apellido2, DateTime fechaNacimiento, int idGenero, int idEstado, string descripcionContacto, int idTipoContacto, string nombreUsuario, string contrasenna, string correo, int idRol)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("CUDPersonaContactoUsuario");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@modo", modo);
                sqlCommand.Parameters.AddWithValue("@cedula", cedula);
                sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                sqlCommand.Parameters.AddWithValue("@apellido", apellido);
                sqlCommand.Parameters.AddWithValue("@apellido2", apellido2);
                sqlCommand.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                sqlCommand.Parameters.AddWithValue("@Generos_idGenero", idGenero);
                sqlCommand.Parameters.AddWithValue("@Estados_idEstado", idEstado);
                sqlCommand.Parameters.AddWithValue("@descripcionContacto", descripcionContacto);
                sqlCommand.Parameters.AddWithValue("@TipoContactos_idTipoContacto", idTipoContacto);
                sqlCommand.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                sqlCommand.Parameters.AddWithValue("@contrasenna", contrasenna);
                sqlCommand.Parameters.AddWithValue("@correo", correo);
                sqlCommand.Parameters.AddWithValue("@Roles_idRol", idRol);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet GetListadoPersonas()
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("GetListadoPersonas");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet GetPersonaContactoUsuraioXCedula(int cedula)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("GetPersonaContactoUsuraioXCedula");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@cedula", cedula);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet GetListadoUsuarios()
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("GetListadoUsuarios");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet SP_Login(string usuario, string contrasenna)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("SP_Login");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@usuario", usuario);
                sqlCommand.Parameters.AddWithValue("@contrasenna", contrasenna);
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }

        public DataSet GetListadoTarjetas()
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataSet dataSet = new DataSet();
            DataSet result;
            try
            {
                sqlCommand = new SqlCommand("GetListadoTarjetas");
                sqlCommand.CommandType = CommandType.StoredProcedure;
                dataSet = base.EjecutaQueryYRetornaDataset(sqlCommand);
                result = dataSet;
            }
            catch (Exception e)
            {
                result = null;
            }
            finally
            {
                base.Disponse(ref sqlCommand);
                sqlCommand = null;
            }
            return result;
        }
    }
}