using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Data
{
    /// <summary>Contiene los métodos de acceso a datos de la clase 'Costo_Anio'.</summary>
    public partial class Costo_Anio
    {
        private Costo_Anio(){}

        /// <summary>Método que representa la llamada al procedure 'Costo_Anio_Actualizar'</summary>
        static public int Actualizar(Entity.Costo_Anio Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Costo_Anio_Actualizar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idAnio", Uso.NoNulo(Item.idAnio, DBNull.Value));
                oP.AddWithValue("anio", Uso.NoNulo(Item.anio, DBNull.Value));
                oP.AddWithValue("numero", Uso.NoNulo(Item.numero, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Costo_Anio_Insertar'</summary>
        static public int Insertar(Entity.Costo_Anio Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Costo_Anio_Insertar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idAnio", Uso.NoNulo(Item.idAnio, DBNull.Value));
                oP.AddWithValue("anio", Uso.NoNulo(Item.anio, DBNull.Value));
                oP.AddWithValue("numero", Uso.NoNulo(Item.numero, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Costo_Anio_Obtener'</summary>
        static public int Obtener(Entity.Costo_Anio Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Costo_Anio_Obtener";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idAnio", Uso.NoNulo(Item.idAnio, DBNull.Value));
                oP.Add("anio", SqlDbType.Char, 2).Direction = ParameterDirection.Output;
                oP.Add("numero", SqlDbType.Char, 4).Direction = ParameterDirection.Output;

                int NumFila = oComando.ExecuteNonQuery();

                Item.anio = (string)Uso.NoNulo(oP["anio"].Value);
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