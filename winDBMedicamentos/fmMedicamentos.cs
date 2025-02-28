using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace winDBMedicamentos
{
    public partial class fmMedicamentos : Form
    {

        SqlConnection cn = new SqlConnection("data source = DESKTOP-1RTVDHB; Initial Catalog = Medicamentos; Integrated security=true");
        string operacion = "";
        public fmMedicamentos()
        {
            InitializeComponent();
        }

        private void ActualizarDatos()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select m.id, m.Nombre,m.Contenido,m.UnidadMedida," +
                "m.Presentacion,m.PrecioUnitario,l.Nombre as Laboratorio from tblMedicamentos m join " +
                " tblLaboratorios l on m.id_laboratorio=l.id", cn);
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

        private void fmMedicamentos_Load(object sender, EventArgs e)
        {
            SqlDataAdapter daLab = new SqlDataAdapter("select id,Nombre from tblLaboratorios", cn);
            DataTable dtLab = new DataTable();
            try
            {
                daLab.Fill(dtLab);
                this.cbLaboratorio.DataSource = dtLab;
                this.cbLaboratorio.DisplayMember = "Nombre";
                this.cbLaboratorio.ValueMember = "id";

                this.ActualizarDatos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarControles()
        {
            //Limpiar controles
            this.textBox1.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtMedida.Text = string.Empty;
            this.txtContenido.Text = string.Empty;
            this.txtPresentacion.Text = string.Empty;
            this.txtPrecio.Text = string.Empty;

            //Habilitar controles
            this.textBox1.ReadOnly = false;
            this.txtName.ReadOnly = false;
            this.txtMedida.ReadOnly = false;
            this.txtContenido.ReadOnly = false;
            this.txtPresentacion.ReadOnly = false;
            this.txtPrecio.ReadOnly = false;

            this.txtName.Focus();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            //this.NoRegis++;
            //this.MostratDatos(NoRegis);//ANTERIOS SIGUIENTE
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }


        private void InhabilitarControles()
        {
            //Inhabilitar controles                   
            this.textBox1.ReadOnly = true;
            this.txtName.ReadOnly = true;
            this.txtMedida.ReadOnly = true;
            this.txtContenido.ReadOnly = true;
            this.txtPresentacion.ReadOnly = true;
            this.txtPrecio.ReadOnly = true;

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
        {
            string strSql = "";
            if (this.operacion == "Nuevo")
            {
                strSql = "insert into tblmedicamentos(Nombre,Unidadmedida,Contenido,Presentacion,PrecioUnitario,id_laboratorio) values ('" + this.txtName.Text + "','" + this.txtMedida.Text + "'," + this.txtContenido.Text + ",'" + this.txtPresentacion.Text + "'," + this.txtPrecio.Text + "," + this.cbLaboratorio.SelectedValue + ")";

            }
            else
            {
                strSql = "update tblmedicamentos set Nombre ='" + this.txtName.Text + "', UnidadMedida='" +
                    this.txtContenido.Text + "', Contenido=" + this.txtContenido.Text + ", Presentacion='" +
                    this.txtPresentacion.Text + "', PrecioUnitario=" + this.txtPrecio.Text + ", id_laboratorio=" +
                    this.cbLaboratorio.SelectedValue + " where id=" + this.textBox1.Text;
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
                this.LimpiarControles();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.textBox1.Text = this.dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            this.txtName.Text = this.dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            this.txtMedida.Text = this.dataGridView1.CurrentRow.Cells["UnidadMedida"].Value.ToString();
            this.txtContenido.Text = this.dataGridView1.CurrentRow.Cells["Contenido"].Value.ToString();
            this.txtPresentacion.Text = this.dataGridView1.CurrentRow.Cells["Presentacion"].Value.ToString();
            this.txtPrecio.Text = this.dataGridView1.CurrentRow.Cells["PrecioUnitario"].Value.ToString();


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
            this.textBox1.ReadOnly = false;
            this.txtName.ReadOnly = false;
            this.txtMedida.ReadOnly = false;
            this.txtContenido.ReadOnly = false;
            this.txtPresentacion.ReadOnly = false;
            this.txtPrecio.ReadOnly = false;

            this.btnNuevo.Enabled = false;
            this.btnGuardar.Enabled = true;
            this.btnModificar.Enabled = false;
            this.btnEliminar.Enabled = true;
            this.btnCancelar.Enabled = true;

            this.txtName.Focus();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro? ", "ELIMINAR", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string StrSql = "DELETE FROM tblMedicamentos where id=" + this.textBox1.Text;
                SqlCommand cmd = new SqlCommand(StrSql, cn);
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
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }



        private void cbLaboratorio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
/*insert into tblMedicamentos(Nombre,UnidadMedida,Contenido,Presentacion,
Id_laboratorio, PrecioUnitario)

values('Ketorolaco','mg','500','Caja',1,66.50);


update tblMedicamentos set Nombre='Diezepan', UnidadMedida = 'mg', Contenido = 'caja', id_laboratorio = 2, PrecioUnitario = 100;
MISMO BOTON DE GUARDAR ES MODIFICAR
 */
