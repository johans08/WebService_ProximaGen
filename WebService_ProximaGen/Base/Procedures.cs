﻿using System;
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
    }
}