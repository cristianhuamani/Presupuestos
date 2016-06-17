using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using ControlPresupuesto;
using DogoHelp;

namespace ControlPresupuesto.Data
{
    /// <summary>Contiene los métodos de acceso a datos de la clase 'Cliente'.</summary>
    public partial class Cliente
    {
        private Cliente(){}

        /// <summary>Método que representa la llamada al procedure 'Cliente_Actualizar'</summary>
        static public int Actualizar(Entity.Cliente Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Cliente_Actualizar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idCliente", Uso.NoNulo(Item.idCliente, DBNull.Value));
                oP.AddWithValue("ruc", Uso.NoNulo(Item.ruc, DBNull.Value));
                oP.AddWithValue("cliente", Uso.NoNulo(Item.cliente, DBNull.Value));
                oP.AddWithValue("direccion", Uso.NoNulo(Item.direccion, DBNull.Value));
                oP.AddWithValue("contacto", Uso.NoNulo(Item.contacto, DBNull.Value));
                oP.AddWithValue("correo", Uso.NoNulo(Item.correo, DBNull.Value));
                oP.AddWithValue("telefono", Uso.NoNulo(Item.telefono, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Cliente_Insertar'</summary>
        static public int Insertar(Entity.Cliente Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Cliente_Insertar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.Add("idCliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                oP.AddWithValue("ruc", Uso.NoNulo(Item.ruc, DBNull.Value));
                oP.AddWithValue("cliente", Uso.NoNulo(Item.cliente, DBNull.Value));
                oP.AddWithValue("direccion", Uso.NoNulo(Item.direccion, DBNull.Value));
                oP.AddWithValue("contacto", Uso.NoNulo(Item.contacto, DBNull.Value));
                oP.AddWithValue("correo", Uso.NoNulo(Item.correo, DBNull.Value));
                oP.AddWithValue("telefono", Uso.NoNulo(Item.telefono, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                int NumFila = oComando.ExecuteNonQuery();

                Item.idCliente = (int?)Uso.NoNulo(oP["idCliente"].Value);

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>Método que representa la llamada al procedure 'Cliente_Listar'</summary>
        static public List<Entity.Cliente.Listar> Listar(Entity.Cliente Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Cliente.Listar>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Cliente_Listar";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idCliente", Uso.NoNulo(Item.idCliente, DBNull.Value));
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Cliente.Listar();
                        LItem.idCliente = (int)oLector["idCliente"];
                        LItem.ruc = (string)oLector["ruc"];
                        LItem.cliente = (string)oLector["cliente"];
                        LItem.direccion = (string)oLector["direccion"];
                        LItem.contacto = (string)oLector["contacto"];
                        LItem.correo = (string)Uso.NoNulo(oLector["correo"]);
                        LItem.telefono = (string)oLector["telefono"];
                        LItem.idEstado = (string)Uso.NoNulo(oLector["idEstado"]);
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

        /// <summary>Método que representa la llamada al procedure 'Cliente_ListarDes'</summary>
        static public List<Entity.Cliente.ListarDes> ListarDes(Entity.Cliente Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Cliente.ListarDes>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Cliente_ListarDes";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idEstado", Uso.NoNulo(Item.idEstado, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Cliente.ListarDes();
                        LItem.idCliente = (int)oLector["idCliente"];
                        LItem.cliente = (string)oLector["cliente"];
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

        /// <summary>Método que representa la llamada al procedure 'Cliente_ListarUso'</summary>
        static public List<Entity.Cliente.ListarUso> ListarUso(Entity.Cliente Item, Cursor oCursor)
        {
            var ResultSet = new List<Entity.Cliente.ListarUso>();
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Cliente_ListarUso";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("ruc", Uso.NoNulo(Item.ruc, DBNull.Value));
                oP.AddWithValue("cliente", Uso.NoNulo(Item.cliente, DBNull.Value));
                oP.AddWithValue("direccion", Uso.NoNulo(Item.direccion, DBNull.Value));
                oP.AddWithValue("contacto", Uso.NoNulo(Item.contacto, DBNull.Value));
                oP.AddWithValue("telefono", Uso.NoNulo(Item.telefono, DBNull.Value));

                using (SqlDataReader oLector = oComando.ExecuteReader())
                {
                    while (oLector.Read())
                    {
                        var LItem = new Entity.Cliente.ListarUso();
                        LItem.idCliente = (int)oLector["idCliente"];
                        LItem.ruc = (string)oLector["ruc"];
                        LItem.cliente = (string)oLector["cliente"];
                        LItem.direccion = (string)oLector["direccion"];
                        LItem.contacto = (string)oLector["contacto"];
                        LItem.correo = (string)Uso.NoNulo(oLector["correo"]);
                        LItem.telefono = (string)oLector["telefono"];
                        LItem.estado = (string)Uso.NoNulo(oLector["estado"]);
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

        /// <summary>Método que representa la llamada al procedure 'Cliente_Obtener'</summary>
        static public int Obtener(Entity.Cliente Item, Cursor oCursor)
        {
            SqlCommand oComando = oCursor.ObtenerComando(Contexto.CnControlPresupuesto);
            string Esquema = Galeria.Conexiones[(int)Contexto.CnControlPresupuesto].EsquemaDefecto;
            oComando.CommandText = Esquema + "Cliente_Obtener";
            try
            {
                SqlParameterCollection oP = oComando.Parameters;
                oP.AddWithValue("idCliente", Uso.NoNulo(Item.idCliente, DBNull.Value));
                oP.Add("ruc", SqlDbType.Char, 11).Direction = ParameterDirection.Output;
                oP.Add("cliente", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                oP.Add("direccion", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                oP.Add("contacto", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                oP.Add("correo", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output;
                oP.Add("telefono", SqlDbType.VarChar, 11).Direction = ParameterDirection.Output;
                oP.Add("idEstado", SqlDbType.Char, 1).Direction = ParameterDirection.Output;

                int NumFila = oComando.ExecuteNonQuery();

                Item.ruc = (string)Uso.NoNulo(oP["ruc"].Value);
                Item.cliente = (string)Uso.NoNulo(oP["cliente"].Value);
                Item.direccion = (string)Uso.NoNulo(oP["direccion"].Value);
                Item.contacto = (string)Uso.NoNulo(oP["contacto"].Value);
                Item.correo = (string)Uso.NoNulo(oP["correo"].Value);
                Item.telefono = (string)Uso.NoNulo(oP["telefono"].Value);
                Item.idEstado = (string)Uso.NoNulo(oP["idEstado"].Value);

                return NumFila;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

    }
}