using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Data
{
    /// <summary>Contiene los métodos de acceso a datos de la clase 'Documento_correlativo'.</summary>
    public partial class Documento_correlativo
    {
        private Documento_correlativo(){}

        /// <summary>Método que representa la llamada al procedure 'Documento_correlativo_Act'</summary>
        static public int Act(Entity.Documento_correlativo Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Documento_correlativo_Act";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("doc", Uso.NoNulo(Item.doc, DBNull.Value));
                oP.AddWithValue("numero", Uso.NoNulo(Item.numero, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Documento_correlativo_Insertar'</summary>
        static public int Insertar(Entity.Documento_correlativo Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Documento_correlativo_Insertar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("doc", Uso.NoNulo(Item.doc, DBNull.Value));
                oP.AddWithValue("numero", Uso.NoNulo(Item.numero, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Documento_correlativo_Obtener'</summary>
        static public int Obtener(Entity.Documento_correlativo Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Documento_correlativo_Obtener";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("doc", Uso.NoNulo(Item.doc, DBNull.Value));
                oP.Add("numero", SqlDbType.Char, 5).Direction = ParameterDirection.Output;

                int NumFila = oComando.ExecuteNonQuery();

                Item.numero = (string)Uso.NoNulo(oP["numero"].Value);

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}