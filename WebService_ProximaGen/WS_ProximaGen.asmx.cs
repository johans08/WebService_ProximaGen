using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService_ProximaGen.Base;
using WebService_ProximaGen.Logica;

namespace WebService_ProximaGen
{
    /// <summary>
    /// Summary description for WS_ProximaGen
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WS_ProximaGen : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet AgregarEstado(string descripcionEstado)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Estados(Constantes.agregar, Constantes.vacio, descripcionEstado);
        }

        [WebMethod]
        public DataSet ModificarEstado(int idEstado, string descripcionEstado)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Estados(Constantes.modificar, idEstado, descripcionEstado);
        }

        [WebMethod]
        public DataSet EliminarEstado(int idEstado)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Estados(Constantes.eliminar, idEstado, Constantes.nulo);
        }

        [WebMethod]
        public DataSet LeerEstados(int inicio, int final)
        {
            Procedures _procedures = new Procedures();
            return _procedures.Read_Estados(inicio, final);
        }


        [WebMethod]
        public DataSet AgregarTipoContacto(string descripcionTipoContacto)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Tipo_Contactos(Constantes.agregar, Constantes.vacio, descripcionTipoContacto);
        }


        [WebMethod]
        public DataSet ModificarTipoContacto(int idTipoContacto, string descripcionTipoContacto)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Tipo_Contactos(Constantes.modificar, idTipoContacto, descripcionTipoContacto);
        }

        [WebMethod]
        public DataSet EliminarTipoContacto(int idTipoContacto)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Tipo_Contactos(Constantes.eliminar, idTipoContacto, Constantes.nulo);
        }

        [WebMethod]
        public DataSet LeerTipoContactos(int inicio, int final)
        {
            Procedures _procedures = new Procedures();
            return _procedures.Read_Tipo_Contactos(inicio, final);
        }

        [WebMethod]
        public DataSet AgregarRol(string descripcionRol)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Roles(Constantes.agregar, Constantes.vacio, descripcionRol);
        }


        [WebMethod]
        public DataSet ModificarRol(int idRol, string descripcionRol)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Roles(Constantes.modificar, idRol, descripcionRol);
        }

        [WebMethod]
        public DataSet EliminarRol(int idRol)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Roles(Constantes.eliminar, idRol, Constantes.nulo);
        }

        [WebMethod]
        public DataSet LeerRoles(int inicio, int final)
        {
            Procedures _procedures = new Procedures();
            return _procedures.Read_Roles(inicio, final);
        }

        [WebMethod]
        public DataSet AgregarPermisoXRol(int idPermiso, int idRol)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_AsignarPermisoXRol(Constantes.agregar, idPermiso, idRol);
        }

        [WebMethod]
        public DataSet ModificarPermisoXRol(int idPermiso, int idRol)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_AsignarPermisoXRol(Constantes.modificar, idPermiso, idRol);
        }

        [WebMethod]
        public DataSet EliminarPermisoXRol(int idPermiso, int idRol)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_AsignarPermisoXRol(Constantes.eliminar, idPermiso, idRol);
        }

        [WebMethod]
        public DataSet LeerPermisosXRoles(int idRol)
        {
            Procedures _procedures = new Procedures();
            return _procedures.Read_PermisosXRol(idRol);
        }

    }
}
