using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Data
{
    /// <summary>Contiene los métodos de acceso a datos de la clase 'Sexo'.</summary>
    public partial class Sexo
    {
        private Sexo(){}

        /// <summary>Método que representa la llamada al procedure 'Sexo_ListarDes'</summary>
        static public List<Entity.Sexo.ListarDes> ListarDes(Entity.Sexo Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Sexo.ListarDes>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Sexo_ListarDes";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Sexo.ListarDes();
                        LItem.idSexo = (string)oLector["idSexo"];
                        LItem.sexo = (string)oLector["sexo"];
                        ResultSet.Add(LItem);
                    }
                }
                return ResultSet;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}