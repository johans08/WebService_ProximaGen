using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebService_ProximaGen.Base
{
    public class BaseDatos
    {

        private static string StringConexion;
        private static int TiempoSentenciaCumplido;
        public static string _strServerConnectionString;

        public int GetTiempoSentenciaCumplido
        {
            get
            {
                int result;
                try
                {
                    BaseDatos.TiempoSentenciaCumplido = 30;
                    if (BaseDatos.TiempoSentenciaCumplido <= 0)
                    {
                        result = 100;
                    }
                    else
                    {
                        result = BaseDatos.TiempoSentenciaCumplido;
                    }
                }
                catch (Exception)
                {
                    result = 30;
                }
                return result;
            }
        }

        public BaseDatos()
        {
            BaseDatos._strServerConnectionString = string.Empty;
            BaseDatos.StringConexion = string.Empty;
            BaseDatos.TiempoSentenciaCumplido = 0;
        }



        public SqlConnection ConexionRegedit()
        {
            SqlConnection sqlConnection = null;
            try
            {
                string stringConnection = ConfigurationManager.ConnectionStrings["WebService_ProximaGen.Properties.Settings.Setting"].ConnectionString;

                BaseDatos.StringConexion = stringConnection;
                sqlConnection = new SqlConnection(BaseDatos.StringConexion);
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return sqlConnection;
        }

        public void Disponse(ref SqlCommand cmdSQLcommand)
        {
            try
            {
                if (cmdSQLcommand != null)
                {
                    if (cmdSQLcommand.Transaction != null)
                    {
                        cmdSQLcommand.Transaction.Dispose();
                        cmdSQLcommand.Transaction = null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmdSQLcommand.Dispose();
                cmdSQLcommand = null;
            }
        }
        public void Disponse(ref DataSet dsDataset)
        {
            if (dsDataset != null)
            {
                dsDataset.Dispose();
                dsDataset = null;
            }
        }

        protected int EjecutarQueryNoRetorna(ref SqlCommand sqlcCommand)
        {
            int result;
            try
            {
                sqlcCommand.Connection = this.ConexionRegedit();
                sqlcCommand.CommandTimeout = this.GetTiempoSentenciaCumplido;
                result = sqlcCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlcCommand.Connection.Close();
            }
            return result;
        }

        protected DataSet EjecutaQueryYRetornaDataset(SqlCommand sqlcCommand)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataSet result;
            try
            {
                sqlcCommand.Connection = this.ConexionRegedit();
                sqlcCommand.CommandTimeout = this.GetTiempoSentenciaCumplido;
                sqlDataAdapter = new SqlDataAdapter(sqlcCommand);
                sqlDataAdapter.Fill(dataSet);
                result = dataSet;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.Disponse(ref dataSet);
                if (sqlDataAdapter != null)
                {
                    sqlDataAdapter.Dispose();
                    sqlDataAdapter = null;
                    sqlcCommand.Connection.Close();
                }
            }
            return result;
        }

    }
}