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


    }
}