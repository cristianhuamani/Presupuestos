using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DogoHelp;
using System.Data;
using System.Data.SqlClient;

namespace MerchServicio.Data
{
    public class Documento_Lin_Dao
    {
        //private Documento_Lin() { }

        /// <summary>Método que representa la llamada al procedure 'Documento_Lin_Actualizar'</summary>
        //static public int Actualizar(Modelo.Documento_Lin Item, Cursor oCursor)
        //{
        //    SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
        //    string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
        //    oComando.CommandText = Esquema + "Documento_Lin_Actualizar";
        //    try
        //    {
        //        SqlParameterCollection oP = oComando.Parameters;
        //        oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
        //        oP.AddWithValue("doc", Uso.NoNulo(Item.doc, DBNull.Value));
        //        oP.AddWithValue("numero", Uso.NoNulo(Item.numero, DBNull.Value));
        //        oP.AddWithValue("idPartida", Uso.NoNulo(Item.idPartida, DBNull.Value));
        //        oP.AddWithValue("ej", Uso.NoNulo(Item.ej, DBNull.Value));
        //        oP.AddWithValue("mes", Uso.NoNulo(Item.mes, DBNull.Value));
        //        oP.AddWithValue("cantidad", Uso.NoNulo(Item.cantidad, DBNull.Value));
        //        oP.AddWithValue("precio", Uso.NoNulo(Item.precio, DBNull.Value));
        //        oP.AddWithValue("total", Uso.NoNulo(Item.total, DBNull.Value));

        //        int NumFila = oComando.ExecuteNonQuery();

        //        return NumFila;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}

        ///// <summary>Método que representa la llamada al procedure 'Documento_Lin_Eliminar'</summary>
        //static public int Eliminar(Modelo.Documento_Lin Item, Cursor oCursor)
        //{
        //    SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
        //    string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
        //    oComando.CommandText = Esquema + "Documento_Lin_Eliminar";
        //    try
        //    {
        //        SqlParameterCollection oP = oComando.Parameters;
        //        oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
        //        oP.AddWithValue("doc", Uso.NoNulo(Item.doc, DBNull.Value));
        //        oP.AddWithValue("numero", Uso.NoNulo(Item.numero, DBNull.Value));
        //        oP.AddWithValue("idPartida", Uso.NoNulo(Item.idPartida, DBNull.Value));

        //        int NumFila = oComando.ExecuteNonQuery();

        //        return NumFila;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}

        ///// <summary>Método que representa la llamada al procedure 'Documento_Lin_Insertar'</summary>
        //static public int Insertar(Modelo.Documento_Lin Item, Cursor oCursor)
        //{
        //    SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
        //    string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
        //    oComando.CommandText = Esquema + "Documento_Lin_Insertar";
        //    try
        //    {
        //        SqlParameterCollection oP = oComando.Parameters;
        //        oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
        //        oP.AddWithValue("doc", Uso.NoNulo(Item.doc, DBNull.Value));
        //        oP.AddWithValue("numero", Uso.NoNulo(Item.numero, DBNull.Value));
        //        oP.AddWithValue("idPartida", Uso.NoNulo(Item.idPartida, DBNull.Value));
        //        oP.AddWithValue("cantidad", Uso.NoNulo(Item.cantidad, DBNull.Value));
        //        oP.AddWithValue("precio", Uso.NoNulo(Item.precio, DBNull.Value));
        //        oP.AddWithValue("total", Uso.NoNulo(Item.total, DBNull.Value));

        //        int NumFila = oComando.ExecuteNonQuery();

        //        return NumFila;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}

        ///// <summary>Método que representa la llamada al procedure 'Documento_Lin_Listar'</summary>
        //static public List<Modelo.Documento_Lin.Listar> Listar(Modelo.Documento_Lin Item, Cursor oCursor)
        //{
        //    var ResultSet = new List<Modelo.Documento_Lin.Listar>();
        //    SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
        //    string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
        //    oComando.CommandText = Esquema + "Documento_Lin_Listar";
        //    try
        //    {
        //        SqlParameterCollection oP = oComando.Parameters;
        //        oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
        //        oP.AddWithValue("doc", Uso.NoNulo(Item.doc, DBNull.Value));
        //        oP.AddWithValue("numero", Uso.NoNulo(Item.numero, DBNull.Value));
        //        oP.AddWithValue("idPartida", Uso.NoNulo(Item.idPartida, DBNull.Value));

        //        using (SqlDataReader oLector = oComando.ExecuteReader())
        //        {
        //            while (oLector.Read())
        //            {
        //                var LItem = new Modelo.Documento_Lin.Listar();
        //                LItem.ccosto = (string)oLector["ccosto"];
        //                LItem.doc = (string)oLector["doc"];
        //                LItem.numero = (string)oLector["numero"];
        //                LItem.partida = (string)oLector["partida"];
        //                LItem.ej = (string)oLector["ej"];
        //                LItem.mes = (string)oLector["mes"];
        //                LItem.cantidad = (int)oLector["cantidad"];
        //                LItem.precio = (decimal)oLector["precio"];
        //                LItem.total = (decimal)oLector["total"];
        //                ResultSet.Add(LItem);
        //            }
        //        }
        //        return ResultSet;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}

        ///// <summary>Método que representa la llamada al procedure 'Documento_Lin_ListarUso'</summary>
        //static public List<Modelo.Documento_Lin.ListarUso> ListarUso(Modelo.Documento_Lin Item, Cursor oCursor)
        //{
        //    var ResultSet = new List<Modelo.Documento_Lin.ListarUso>();
        //    SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
        //    string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
        //    oComando.CommandText = Esquema + "Documento_Lin_ListarUso";
        //    try
        //    {
        //        SqlParameterCollection oP = oComando.Parameters;
        //        oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
        //        oP.AddWithValue("doc", Uso.NoNulo(Item.doc, DBNull.Value));
        //        oP.AddWithValue("numero", Uso.NoNulo(Item.numero, DBNull.Value));

        //        using (SqlDataReader oLector = oComando.ExecuteReader())
        //        {
        //            while (oLector.Read())
        //            {
        //                var LItem = new Modelo.Documento_Lin.ListarUso();
        //                LItem.idPartida = (string)oLector["idPartida"];
        //                LItem.partida = (string)oLector["Partida"];
        //                LItem.cantidad = (int)oLector["cantidad"];
        //                LItem.precio = (decimal)oLector["precio"];
        //                LItem.total = (decimal)oLector["total"];
        //                ResultSet.Add(LItem);
        //            }
        //        }
        //        return ResultSet;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}

        ///// <summary>Método que representa la llamada al procedure 'Documento_Lin_Obtener'</summary>
        //static public int Obtener(Modelo.Documento_Lin Item, Cursor oCursor)
        //{
        //    SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
        //    string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
        //    oComando.CommandText = Esquema + "Documento_Lin_Obtener";
        //    try
        //    {
        //        SqlParameterCollection oP = oComando.Parameters;
        //        oP.AddWithValue("ccosto", Uso.NoNulo(Item.ccosto, DBNull.Value));
        //        oP.AddWithValue("doc", Uso.NoNulo(Item.doc, DBNull.Value));
        //        oP.AddWithValue("numero", Uso.NoNulo(Item.numero, DBNull.Value));
        //        oP.AddWithValue("idPartida", Uso.NoNulo(Item.idPartida, DBNull.Value));
        //        oP.Add("ej", SqlDbType.Char, 4).Direction = ParameterDirection.Output;
        //        oP.Add("mes", SqlDbType.Char, 2).Direction = ParameterDirection.Output;
        //        oP.Add("cantidad", SqlDbType.Int).Direction = ParameterDirection.Output;
        //        oP.Add(new SqlParameter("precio", SqlDbType.Decimal, 0, ParameterDirection.Output, false, 12, 2, null, DataRowVersion.Default, null));
        //        oP.Add(new SqlParameter("total", SqlDbType.Decimal, 0, ParameterDirection.Output, false, 12, 2, null, DataRowVersion.Default, null));

        //        int NumFila = oComando.ExecuteNonQuery();

        //        Item.ej = (string)Uso.NoNulo(oP["ej"].Value);
        //        Item.mes = (string)Uso.NoNulo(oP["mes"].Value);
        //        Item.cantidad = (int?)Uso.NoNulo(oP["cantidad"].Value);
        //        Item.precio = (decimal?)Uso.NoNulo(oP["precio"].Value);
        //        Item.total = (decimal?)Uso.NoNulo(oP["total"].Value);

        //        return NumFila;
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}