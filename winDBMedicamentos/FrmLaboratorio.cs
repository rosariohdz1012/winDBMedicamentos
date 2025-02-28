using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winDBMedicamentos
{
    public partial class FrmLaboratorio : Form
    {
        SqlConnection cn = new SqlConnection("data source = DESKTOP-1RTVDHB; Initial Catalog = Medicamentos; Integrated security=true");
        string operacion = "";

        public FrmLaboratorio()
        {
            InitializeComponent();
        }

        private void ActualizarDatos()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select id,Nombre,Contacto,Telefono from tblLaboratorios", cn);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                this.dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           private void FrmLaboratorio_Load(object sender, EventArgs e)
        {
            SqlDataAdapter daMed = new SqlDataAdapter("select id,Nombre,Contacto,Telefono from tblLaboratorios", cn);
             DataTable dtMed = new DataTable();
            try
            {
                daMed.Fill(dtMed);

                this.dataGridView1.DataSource = dtMed;
             
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            //Limpiar controles
            this.txtId.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtContacto.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;

            //Habilitar controles
            this.txtId.ReadOnly = false;
            this.txtNombre.ReadOnly = false;
            this.txtContacto.ReadOnly = false;
            this.txtTelefono.ReadOnly = false;
           

            this.txtNombre.Focus();
        }

        private void InhabilitarControles()
        {

            //Inhabilitar controles
            this.txtId.ReadOnly = true;
            this.txtNombre.ReadOnly = true;
            this.txtContacto.ReadOnly = true;
            this.txtTelefono.ReadOnly = true;

            this.btnNuevo.Enabled = true;
            this.btnGuardar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnCancelar.Enabled = false;
        
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.operacion = "Nuevo";
            this.btnNuevo.Enabled = false;
            this.btnGuardar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnCancelar.Enabled = true;
            this.LimpiarControles();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {///errr
            string strSql = "";
            if (this.operacion == "Nuevo")
            {
                strSql = "insert into tblLaboratorios(Nombre,Contacto,Telefono) values ('" + this.txtNombre.Text + "','" + this.txtContacto.Text + "'," + this.txtTelefono.Text + ")";

            }
            else
            {
                strSql = "update tblLaboratorios set Nombre ='" + this.txtNombre.Text + "', Contacto=" + this.txtContacto.Text +"', Telefono='"  + this.txtTelefono.Text +
                     "' where id=" + this.txtId.Text;
            }
            SqlCommand cmd = new SqlCommand(strSql, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Operacion exitosa");
                this.InhabilitarControles();
                this.ActualizarDatos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender,EventArgs e)
        {
            this.txtId.Text = this.dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            this.txtNombre.Text = this.dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            this.txtContacto.Text = this.dataGridView1.CurrentRow.Cells["Contacto"].Value.ToString();
            this.txtTelefono.Text = this.dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            

            this.btnNuevo.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.btnModificar.Enabled = true;
            this.btnEliminar.Enabled = true;
            this.btnCancelar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.InhabilitarControles();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.operacion = "Modificar";
            //Habilitar controles                   
            this.txtId.ReadOnly = false;
            this.txtNombre.ReadOnly = false;
            this.txtContacto.ReadOnly = false;
            this.txtTelefono.ReadOnly = false;
           

            this.btnNuevo.Enabled = false;
            this.btnGuardar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = true;
            this.btnCancelar.Enabled = true;

            this.txtNombre.Focus();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro? ", "ELIMINAR", MessageBoxButtons.YesNo
             , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string strSql = "DELETE FROM tblLaboratorios where id = " + this.txtId.Text;
                SqlCommand cmd = new SqlCommand(strSql, cn);
                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Eliminacion Exitosa");
                    this.InhabilitarControles();
                    this.ActualizarDatos();
                }
                catch (SqlException ex)
                {
                    {
                        MessageBox.Show("El laboratorio no se puede eliminar");
                    }
                }
            }
        }

  private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

  private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

  private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

 private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }

 private void btnInicio_Click(object sender, EventArgs e)
        {
        }

 private void btnAnterior_Click(object sender, EventArgs e)
        {
        }

 private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
        }

 private void btnUltimo_Click(object sender, EventArgs e)
        {
        }
  
private void label1_Click(object sender, EventArgs e)
{

}

 private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        }
    }
