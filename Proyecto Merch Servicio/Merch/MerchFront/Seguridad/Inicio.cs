using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;
using ControlPresupuesto.Logic;
using DogoHelp;
using MerchFront.Formularios;

namespace ControlPresupuesto.Front
{
    public static class Inicio
    {
        public static void Main()
        {
            try 
	         {
                Application.EnableVisualStyles();

                //Establecer los parametros del archivo de configuración
                var CnControlPresupuesto = new Conexion();
                CnControlPresupuesto.CadenaConexion = ConfigurationManager.ConnectionStrings["CnControlPresupuesto"].ConnectionString;
                CnControlPresupuesto.Proveedor = ConfigurationManager.ConnectionStrings["CnControlPresupuesto"].ProviderName;
                CnControlPresupuesto.EsquemaDefecto = ConfigurationManager.AppSettings["CnControlPresupuesto.EsquemaDefecto"];
                Galeria.Conexiones.Add(CnControlPresupuesto);

                Galeria.ClaveEncriptacion = "ControlPresupuesto";

                //Inicaia el Login
                FrmLogin oLogin = new FrmLogin();
                if (oLogin.ShowDialog() == DialogResult.OK)
                {
                    MdiPrincipal oMdi = new MdiPrincipal();
                    oMdi.ShowDialog();
                }

            }
            catch (System.Exception ex)
            {
                Utilidad.ImprimirError(ex, DateTime.Now);
            }
        }
    }
}