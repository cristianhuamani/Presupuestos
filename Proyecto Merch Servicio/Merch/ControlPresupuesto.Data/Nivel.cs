using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Data
{
    /// <summary>Contiene los métodos de acceso a datos de la clase 'Nivel'.</summary>
    public partial class Nivel
    {
        private Nivel(){}

        /// <summary>Método que representa la llamada al procedure 'Nivel_ListarDes'</summary>
        static public List<Entity.Nivel.ListarDes> ListarDes(Entity.Nivel Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Nivel.ListarDes>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Nivel_ListarDes";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Nivel.ListarDes();
                        LItem.idNivel = (string)oLector["idNivel"];
                        LItem.Nivel = (string)oLector["Nivel"];
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