using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SrvRRF;
using System.Data;

namespace EditorImportacion
{
    class clst661
    {
        private short prvIntTipo;
        private short prvIntSubtipo;
        private short prvIntVersion;
        private string prvStrDescripcion;
        private short prvIntIndTipoProceso;
        private short prvIntIndOrdenProceso;
        private short prvIntIndDocumento;

        public DataSet pubDSCampos;
        public DataSet pubDSSubtipos;

        private string prvStrSctipt;

        public clst661(short pvIntTipo, short pvIntSubtipo, short pvIntVersion)
        {
            prvIntTipo = pvIntTipo;
            prvIntSubtipo = pvIntSubtipo;
            prvIntVersion = pvIntVersion;
        }

        public clst661(short pvIntTipo, short pvIntSubtipo, short pvIntVersion, string pvStrDescripcion, short pvIntIndTipoProceso, short pvIntIndOrdenProceso, short pvIntIndDocumento)
        {
            prvIntTipo = pvIntTipo;
            prvIntSubtipo = pvIntSubtipo;
            prvIntVersion = pvIntVersion;
            prvStrDescripcion = pvStrDescripcion;
            prvIntIndTipoProceso = pvIntIndTipoProceso;
            prvIntIndOrdenProceso = pvIntIndOrdenProceso;
            prvIntIndDocumento = pvIntIndDocumento;
        }

        public bool ConsultarPropiedades()
        {
            string vStrCadena;
            DataSet vDSDatos;
            
            bool vProceso;
            vProceso = false;
            clsConexionBD vObjConexion = ObtenerConexion();
            vStrCadena = "select * from t661_imp_tablas where f661_tipo_reg = " + prvIntTipo.ToString();
            vStrCadena += " and f661_subtipo_reg =" + prvIntSubtipo.ToString();
            vStrCadena += " and f661_version =" + prvIntVersion.ToString();
            vObjConexion.EjecutarSentencia(clsConexionBD.pubEnumTipoEjecucion.ConRetorno, vStrCadena);
            vDSDatos = vObjConexion.pubDSDatos;
            foreach (DataRow fila in vDSDatos.Tables[0].Rows)
            {
                prvStrDescripcion = fila["f661_descripcion"].ToString();
                prvIntIndOrdenProceso = short.Parse(fila["f661_orden_proceso"].ToString());
                prvIntIndTipoProceso = short.Parse(fila["f661_ind_tipo_proceso"].ToString());
                prvIntIndDocumento = short.Parse(fila["f661_ind_documento"].ToString());
                prvStrSctipt = fila["f661_script_sp"].ToString();
            }
            vProceso = true;
            return vProceso;
        }

        public bool ConsultarCampos()
        {
            string vStrCadena;
            clsConexionBD vObjConexion = ObtenerConexion();
            vStrCadena = "select * from t662_imp_campos where f662_tipo_reg = " + prvIntTipo.ToString();
            vStrCadena += " and f662_subtipo_reg =" + prvIntSubtipo.ToString();
            vStrCadena += " and f662_version =" + prvIntVersion.ToString();
            vStrCadena += " order by f662_ind_complemento, f662_posicion_inicial";
            vObjConexion.EjecutarSentencia(clsConexionBD.pubEnumTipoEjecucion.ConRetorno, vStrCadena);
            pubDSCampos = vObjConexion.pubDSDatos;

            return true;
        }


        public bool ConsultarSubtipos()
        {
            string vStrCadena;
            clsConexionBD vObjConexion = ObtenerConexion();
            vStrCadena = "select * from t6611_imp_tablas_tipo_reg where f6611_tipo_reg = " + prvIntTipo.ToString();
            vStrCadena += " and f6611_subtipo_reg =" + prvIntSubtipo.ToString();
            vStrCadena += " and f6611_version =" + prvIntVersion.ToString();
            vObjConexion.EjecutarSentencia(clsConexionBD.pubEnumTipoEjecucion.ConRetorno, vStrCadena);
            pubDSSubtipos = vObjConexion.pubDSDatos;

            return true;
        }

        public string getStrDescripcion()
        {
            return prvStrDescripcion;
        }

        public string getStrSctipt()
        {
            return prvStrSctipt;
        }

        

        public short getIntIndTipoProceso()
        {
            return prvIntIndTipoProceso;
        }

        public short getIntIndOrdenProceso()
        {
            return prvIntIndOrdenProceso;
        }

        public short getIntIndDocumento()
        {
            return prvIntIndDocumento;
        }

        public string ConstruirSentencias(short pvIntTipo, short pvIntSubtipo, short pvIntVersion, DataTable pvDtDatos, DataTable pvDtSubtipo, string pvStrDescripcion, short pvIntOrdenProceso, short pvIntIndTipoProceso, short pvIntIndDocumento)
        {
            string vStrResultado, vStrPlantilla, vStrLinea;
            
            if (pvDtDatos == null)
            {
                return "";
            }

            pvDtDatos.AcceptChanges();
            vStrResultado = "begin tran\n\n";
            vStrResultado += "delete from t6611_imp_tablas_tipo_reg where f6611_tipo_reg = @tipo_reg and  f6611_subtipo_reg = @subtipo_reg and f6611_version = @version\nGO\n\n";
            vStrResultado += "delete from t662_imp_campos where f662_tipo_reg = @tipo_reg and  f662_subtipo_reg = @subtipo_reg and f662_version = @version\nGO\n\n";
            vStrResultado += "delete from t661_imp_tablas where f661_tipo_reg = @tipo_reg and  f661_subtipo_reg = @subtipo_reg and f661_version = @version\nGO\n\n";

            vStrResultado += "insert into t661_imp_tablas (f661_tipo_reg, f661_subtipo_reg, f661_version, f661_descripcion, f661_orden_proceso, f661_script_sp, f661_ind_tipo_proceso, f661_script_sp_net, f661_ind_documento)";
            vStrResultado += " values (@tipo_reg, @subtipo_reg, @version, '@descripcion', @orden_proceso, null, @ind_tipo_proceso, null, @ind_documento)";
            vStrResultado += "\nGO\n\n";

            vStrResultado = vStrResultado.Replace("@descripcion", pvStrDescripcion);
            vStrResultado = vStrResultado.Replace("@orden_proceso", pvIntOrdenProceso.ToString());
            vStrResultado = vStrResultado.Replace("@ind_tipo_proceso", pvIntIndTipoProceso.ToString());
            vStrResultado = vStrResultado.Replace("@ind_documento", pvIntIndDocumento.ToString());

            vStrPlantilla = "insert into t662_imp_campos (f662_tipo_reg, f662_subtipo_reg, f662_version, f662_campo, f662_tipo_dato, f662_posicion_inicial, f662_tamano, f662_tipo_dato_sql, f662_ind_obligatorio, f662_ind_complemento, f662_ind_select_final, f662_orden_select_final, f662_descripcion, f662_observacion, f662_ind_signo, f662_nro_enteros, f662_nro_decimales)";
            vStrPlantilla += " values (@tipo_reg, @subtipo_reg, @version, '@campo', @tipo_dato, @posicion_inicial, @tamano, '@tipo_dato_sql', @ind_obligatorio, @ind_complemento, @ind_select_final, @orden_select_final, '@descripcion', '@observacion', @ind_signo, @nro_enteros, @nro_decimales)";
            vStrPlantilla += "\nGO\n\n";
            /*vStrPlantilla = vStrPlantilla.Replace("@tipo_reg", pvIntTipo.ToString());
            vStrPlantilla = vStrPlantilla.Replace("@subtipo_reg", pvIntSubtipo.ToString());
            vStrPlantilla = vStrPlantilla.Replace("@version", pvIntVersion.ToString());*/
            
            foreach (DataRow vFila in pvDtDatos.Rows)
            {
                vStrLinea = vStrPlantilla;
                vStrLinea = vStrLinea.Replace("@tipo_dato_sql", vFila["f662_tipo_dato_sql"].ToString());
                vStrLinea = vStrLinea.Replace("@campo", vFila["f662_campo"].ToString());
                vStrLinea = vStrLinea.Replace("@tipo_dato", vFila["f662_tipo_dato"].ToString());
                vStrLinea = vStrLinea.Replace("@posicion_inicial", vFila["f662_posicion_inicial"].ToString());
                vStrLinea = vStrLinea.Replace("@tamano", vFila["f662_tamano"].ToString());                
                vStrLinea = vStrLinea.Replace("@ind_obligatorio", EsBlanco(vFila["f662_ind_obligatorio"].ToString(),"0"));
                vStrLinea = vStrLinea.Replace("@ind_complemento", EsBlanco(vFila["f662_ind_complemento"].ToString(),"0"));
                vStrLinea = vStrLinea.Replace("@ind_select_final", vFila["f662_ind_select_final"].ToString());
                vStrLinea = vStrLinea.Replace("@orden_select_final", vFila["f662_orden_select_final"].ToString());
                vStrLinea = vStrLinea.Replace("@descripcion", vFila["f662_descripcion"].ToString());
                vStrLinea = vStrLinea.Replace("@observacion", vFila["f662_observacion"].ToString());
                vStrLinea = vStrLinea.Replace("@ind_signo", EsBlanco(vFila["f662_ind_signo"].ToString(),"null"));
                vStrLinea = vStrLinea.Replace("@nro_enteros", EsBlanco(vFila["f662_nro_enteros"].ToString(), "null"));
                vStrLinea = vStrLinea.Replace("@nro_decimales", EsBlanco(vFila["f662_nro_decimales"].ToString(), "null"));
                vStrResultado += vStrLinea;
            }

            vStrPlantilla = "insert into t6611_imp_tablas_tipo_reg (f6611_ts, f6611_tipo_reg, f6611_subtipo_reg, f6611_version, f6611_tipo_reg_hijo, f6611_subtipo_reg_hijo, f6611_version_reg_hijo)";
            vStrPlantilla += " values (getdate(),@tipo_reg, @subtipo_reg, @version, @tipo_reg_hijo, @subtipo_reg_hijo, @version_reg_hijo)";
            vStrPlantilla += "\nGO\n\n";

            foreach (DataRow vFila in pvDtSubtipo.Rows)
            {
                vStrLinea = vStrPlantilla;
                vStrLinea = vStrLinea.Replace("@tipo_reg_hijo", vFila["f6611_tipo_reg_hijo"].ToString());
                vStrLinea = vStrLinea.Replace("@subtipo_reg_hijo", vFila["f6611_subtipo_reg_hijo"].ToString());
                vStrLinea = vStrLinea.Replace("@version_reg_hijo", vFila["f6611_version_reg_hijo"].ToString());
                vStrResultado += vStrLinea;
            }

            vStrResultado = vStrResultado.Replace("@tipo_reg", pvIntTipo.ToString());
            vStrResultado = vStrResultado.Replace("@subtipo_reg", pvIntSubtipo.ToString());
            vStrResultado = vStrResultado.Replace("@version", pvIntVersion.ToString());

            vStrResultado += "rollback tran \n\n";
            return vStrResultado;
        }

        private string EsBlanco(string pvStrCadena, string pvStrCadenaDefecto)
        {
            bool vBlnBlanco;

            vBlnBlanco = (pvStrCadena == null);
            
            if (!vBlnBlanco)
            {
                vBlnBlanco = ((pvStrCadena.Trim()).Length == 0);
            }

            if (vBlnBlanco)
            {
                return pvStrCadenaDefecto;
            }
            else
            {
                return pvStrCadena;
            }
        }

        private clsConexionBD ObtenerConexion()
        {
            return new clsConexionBD(clsConexionBD.pubEnumTipoBD.SQL, ConfBD.Default.Instancia, ConfBD.Default.BaseDeDatos, ConfBD.Default.Usuario, ConfBD.Default.Contraseña);
        }

    }
    
}
