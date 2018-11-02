using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace SrvRRF
{
    public class clsConexionBD
    {
        public enum pubEnumTipoBD {SQL, ORACLE};
        public enum pubEnumTipoEjecucion {SinRetorno, ConRetorno };
        
        private String prvStrNombreServidor;
        private String prvStrvNombreBD;
        private String prvStrUsuario;
        private String prvStrContraseña;
        private pubEnumTipoBD prvTipoBD;

        private System.Data.SqlClient.SqlConnection prvConexionBDSQL;
        private System.Data.SqlClient.SqlCommand prvCmdSentencia;

        public DataSet pubDSDatos;

        //<summary>Constructor para SQL</summary>
        public clsConexionBD(pubEnumTipoBD pvTipoBD, string pvStrNombreServidor, string pStrvNombreBD, string pvStrUsuario, string pvStrContraseña)
        {
            prvTipoBD = pvTipoBD;
            prvStrNombreServidor = pvStrNombreServidor;
            prvStrvNombreBD = pStrvNombreBD;
            prvStrUsuario = pvStrUsuario;
            prvStrContraseña = pvStrContraseña;
        }

        //<summary>Constructor para ORACLE</summary>
        public clsConexionBD(pubEnumTipoBD pvTipoBD, string pvStrNombreServicio, string pvStrUsuario, string pvStrContraseña)
        {
            prvTipoBD = pvTipoBD;
            prvStrNombreServidor = pvStrNombreServicio;
            prvStrUsuario = pvStrUsuario;
            prvStrContraseña = pvStrContraseña;
        }

        
        private bool IniciarConexion()
        {
            if (prvTipoBD == pubEnumTipoBD.SQL) {
                return IniciarConexionSQL();
            }
            else
            {
                // Para Otacle no se encuentra todavia implementado
                return false;
            }
                
        }

        private bool CerrarConexion()
        {
            if (prvTipoBD == pubEnumTipoBD.SQL)
            {
                return CerrarConexionSQL();
            }
            else
            {
                // Para Otacle no se encuentra todavia implementado
                return false;
            }
        }

        private bool IniciarConexionSQL()
        {
            prvConexionBDSQL = new System.Data.SqlClient.SqlConnection();
            prvConexionBDSQL.ConnectionString = "Data Source="+ prvStrNombreServidor+";" +
                                                "Initial Catalog="+ prvStrvNombreBD +";" +
                                                "User id=" + prvStrUsuario + ";" + 
                                                "Password=" + prvStrContraseña + ";";
            prvConexionBDSQL.Open();
            return true;
        }

        private bool CerrarConexionSQL()
        {
            prvConexionBDSQL.Close();
            return true;
        }

        public void EjecutarSentencia(pubEnumTipoEjecucion pvTipoEjecucion, string pvStrSentencia)
        {
            IniciarConexion();
            prvCmdSentencia = new System.Data.SqlClient.SqlCommand(pvStrSentencia, prvConexionBDSQL);
            switch (pvTipoEjecucion)
            {
                case pubEnumTipoEjecucion.SinRetorno:
                    EjecutarSentenciaSinRetorno(pvStrSentencia);
                    break;
                case pubEnumTipoEjecucion.ConRetorno:
                    EjecutarSentenciaConRetorno(pvStrSentencia);
                    break;
            }
            
            prvCmdSentencia = null;
            CerrarConexion();
        }

        private void EjecutarSentenciaSinRetorno(string pvStrSentencia)
        {
            prvCmdSentencia.ExecuteNonQuery();
        }

        private void EjecutarSentenciaConRetorno(string pvStrSentencia)
        {
            SqlDataAdapter vDATraerDatos;
            vDATraerDatos = new SqlDataAdapter();
            vDATraerDatos.SelectCommand = prvCmdSentencia;

            pubDSDatos = new DataSet();

            vDATraerDatos.Fill(pubDSDatos);

        }

        public string LeerArchivoDeTexto(string pvStrArchivo)
        {
            return System.IO.File.ReadAllText(pvStrArchivo);
        }
    }
}
