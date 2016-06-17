using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MerchServicio.Modelo;


namespace MerchServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IOperaciones" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IOperaciones 
    {
        
        [OperationContract]
        
        void InsertarDocumento(Documento_Cab oDoc,List<Documento_Lin> oLista);

        [OperationContract]
        void ActualizarDocumento(Documento_Cab oDoc, List<Documento_Lin> oLista);

    }
}
