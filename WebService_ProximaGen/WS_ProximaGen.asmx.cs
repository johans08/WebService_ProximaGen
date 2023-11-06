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
        public DataSet AgregarGenero(string genero)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Generos(Constantes.agregar, Constantes.vacio, genero);
        }


        [WebMethod]
        public DataSet ModificarGenero(int idGenero, string genero)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Generos(Constantes.modificar, idGenero, genero);
        }

        [WebMethod]
        public DataSet EliminarGenero(int idGenero)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Generos(Constantes.eliminar, idGenero, Constantes.nulo);
        }

        [WebMethod]
        public DataSet LeerGenero(int inicio, int final)
        {
            Procedures _procedures = new Procedures();
            return _procedures.Read_Generos(inicio, final);
        }


        [WebMethod]
        public DataSet AgregarPermisos(string permiso)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Permisos(Constantes.agregar, Constantes.vacio, permiso);
        }


        [WebMethod]
        public DataSet ModificarPermisos(int idPermiso, string permiso)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Permisos(Constantes.modificar, idPermiso, permiso);
        }

        [WebMethod]
        public DataSet EliminarPermisos(int idPermiso)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Permisos(Constantes.eliminar, idPermiso, Constantes.nulo);
        }

        [WebMethod]
        public DataSet Leer_Permisos(int inicio, int final)
        {
            Procedures _procedures = new Procedures();
            return _procedures.Read_Permisos(inicio, final);
        }


        [WebMethod]
        public DataSet AgregarContactos(string descripcionContacto, int idTipoContacto, int idTipoPersona)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Contactos(Constantes.agregar, Constantes.vacio, descripcionContacto, idTipoContacto, idTipoPersona);
        }


        [WebMethod]
        public DataSet ModificarContactos(int idContacto, string descripcionContacto, int idTipoContacto, int idTipoPersona)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Contactos(Constantes.modificar, idContacto, descripcionContacto, idTipoContacto, idTipoPersona);
        }

        [WebMethod]
        public DataSet EliminarContactos(int idContacto)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Contactos(Constantes.eliminar, idContacto, Constantes.nulo, Constantes.vacio, Constantes.vacio);
        }

        [WebMethod]
        public DataSet Leer_Contactos(int idPersona)
        {
            Procedures _procedures = new Procedures();
            return _procedures.Read_ContactoXPersona(idPersona);
        }


        [WebMethod]
        public DataSet AgregarTarjetas(string numeroTarjeta, int expiracionMes, int expiracionAnno, string cvv,int Personas_idPersona, int Estados_idEstado)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Tarjetas(Constantes.agregar, Constantes.vacio, numeroTarjeta, expiracionMes, expiracionAnno, cvv, Personas_idPersona, Estados_idEstado);
        }


        [WebMethod]
        public DataSet ModificarTarjetas(int idTarjeta, string numeroTarjeta, int expiracionMes, int expiracionAnno, string cvv, int Personas_idPersona, int Estados_idEstado)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Tarjetas(Constantes.modificar, idTarjeta, numeroTarjeta, expiracionMes, expiracionAnno, cvv, Personas_idPersona, Estados_idEstado);
        }

        [WebMethod]
        public DataSet EliminarTarjetas(int idTarjeta)
        {
            Procedures _procedures = new Procedures();
            return _procedures.CUD_Tarjetas(Constantes.eliminar, idTarjeta, Constantes.nulo, Constantes.vacio, Constantes.vacio, Constantes.nulo, Constantes.vacio, Constantes.vacio);
        }

        [WebMethod]
        public DataSet Leer_Tarjetas(int idPersona)
        {
            Procedures _procedures = new Procedures();
            return _procedures.Read_TarjetaXPersona(idPersona);
        }
    }
}
