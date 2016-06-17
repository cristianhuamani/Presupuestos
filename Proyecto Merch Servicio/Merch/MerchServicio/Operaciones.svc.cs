using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MerchServicio.Modelo;
using MerchServicio.Data;

namespace MerchServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Operaciones" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Operaciones.svc o Operaciones.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Operaciones : IOperaciones
    {

        Documento_Cab_Dao oDao = new Documento_Cab_Dao();
        public void ActualizarDocumento(Documento_Cab oDoc, List<Documento_Lin> oLista)
        {
            oDao.Actualizar(oDoc);
        }

        public void InsertarDocumento(Documento_Cab oDoc, List<Documento_Lin> oLista)
        {

            //oDoc.ccosto = "160020";
            //oDoc.doc = "GC";
            //oDoc.numero = "";
            //oDoc.ej = "";
            //oDoc.mes = "";

            //oDoc.idPersona = 1;
            //oDoc.total = 500;
            //oDoc.usr = "";
            //oDoc.idEstado = "A";
            oDao.Insertar(oDoc);
        }
    }
}
