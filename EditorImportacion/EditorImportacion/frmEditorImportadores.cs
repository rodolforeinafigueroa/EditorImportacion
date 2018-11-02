using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorImportacion
{
    public partial class frmEditorImportacion : Form
    {
        private short prvIntTipo;
        private short prvIntSubtipo;
        private short prvIntVersion;
        private string prvStrScript;
        private short prvIntOrdenProceso;
        private short prvIntIndTipoProceso;
        private short prvIntIndDocumento;
        private string prvStrDescripcion;

        public frmEditorImportacion()
        {
            InitializeComponent();
            btnBuscar_Click(null, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
             

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            prvIntTipo = (short)numTipo.Value;
            prvIntSubtipo = (short)numSubtipo.Value;
            prvIntVersion = (short)numVersion.Value;
            clst661 VObjDatos = new clst661(prvIntTipo, prvIntSubtipo, prvIntVersion);
            if (VObjDatos.ConsultarPropiedades()) {
                txtDescripcion.Text = VObjDatos.getStrDescripcion();
                numOrdenProceso.Value = VObjDatos.getIntIndOrdenProceso();
                txtIndDocumento.Text = VObjDatos.getIntIndDocumento().ToString();
                txtTipoProceso.Text = VObjDatos.getIntIndTipoProceso().ToString();
                prvStrScript = VObjDatos.getStrSctipt();
                prvIntOrdenProceso =  VObjDatos.getIntIndOrdenProceso(); 
                prvIntIndTipoProceso =  VObjDatos.getIntIndTipoProceso();
                prvIntIndDocumento = VObjDatos.getIntIndDocumento();
                prvStrDescripcion = VObjDatos.getStrDescripcion(); 
            }
            else
            {
                return;
            }
            VObjDatos.ConsultarCampos();
            dtgrdCampos.AutoGenerateColumns = false;
            dtgrdCampos.DataSource = VObjDatos.pubDSCampos.Tables[0];
            VObjDatos.ConsultarSubtipos();
            dtGrdSubtipos.DataSource = VObjDatos.pubDSSubtipos.Tables[0];
        }

        private void numTipo_Enter(object sender, EventArgs e)
        {
            numTipo.Select(0, numTipo.Text.Length);
        }

        private void numSubtipo_Enter(object sender, EventArgs e)
        {
            numSubtipo.Select(0, numSubtipo.Text.Length);
        }

        private void numVersion_Enter(object sender, EventArgs e)
        {
            numVersion.Select(0, numVersion.Text.Length);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btlGuardar_Click(object sender, EventArgs e)
        {
            short vIntTipo, vIntSubtipo, vIntVersion, vIntOrdenProceso, vIntIndTipoProceso, vIntIndDocumento;
            string vStrDescripcion;
            
            if (chkDatosFiltro.Checked)
            {
                vIntTipo = (short)numTipo.Value;
                vIntSubtipo = (short)numSubtipo.Value ;
                vIntVersion = (short)numVersion.Value;
                vIntOrdenProceso = (short)numOrdenProceso.Value;
                vIntIndTipoProceso = short.Parse(txtTipoProceso.Text);
                vIntIndDocumento = short.Parse(txtIndDocumento.Text);
                vStrDescripcion = txtDescripcion.Text;
            }else
            {
                vIntTipo = prvIntTipo;
                vIntSubtipo = prvIntSubtipo;
                vIntVersion = prvIntVersion;
                vIntOrdenProceso = prvIntOrdenProceso;
                vIntIndTipoProceso = prvIntIndTipoProceso;
                vIntIndDocumento = prvIntIndDocumento;
                vStrDescripcion = prvStrDescripcion;
            }
            
        clst661 VObjDatos = new clst661(vIntTipo, vIntSubtipo, vIntVersion);
            new frmScript(VObjDatos.ConstruirSentencias(vIntTipo, vIntSubtipo, vIntVersion, (DataTable)dtgrdCampos.DataSource, (DataTable)dtGrdSubtipos.DataSource,vStrDescripcion,vIntOrdenProceso,vIntIndTipoProceso, vIntIndDocumento)).ShowDialog();
        }

        private void btnActualizarScript_Click(object sender, EventArgs e)
        {
            new frmScript(prvStrScript).ShowDialog();
        }

        private void dtgrdCampos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
