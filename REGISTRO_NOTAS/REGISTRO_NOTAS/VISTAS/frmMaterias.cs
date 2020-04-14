using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REGISTRO_NOTAS.MODEL;

namespace REGISTRO_NOTAS.VISTAS
{
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
            txtNombreMateria.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            
        }

       

        void Limpiar()
        {
            txtId.Text = "";
            txtNombreMateria.Text = "";
        }

        void cargar()
        {
            using (REGISTROEntities bd = new REGISTROEntities())
            {
                dgvMaterias.DataSource = bd.Materias.ToList();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {

            using (REGISTROEntities bd = new REGISTROEntities())
            {
                var lista = from materias in bd.Materias


                            select new
                            {
                                ID = materias.Id_materia,
                                NOMBRE = materias.nombre_materia

                            };

                dgvMaterias.DataSource = lista.ToList();
            }

        }

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvMaterias.CurrentRow.Cells[0].Value.ToString();
            string nombreMa = dgvMaterias.CurrentRow.Cells[1].Value.ToString();
            txtId.Text = id;
            txtNombreMateria.Text = nombreMa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombreMateria.Text != "") { 
            
            using (REGISTROEntities bd = new REGISTROEntities ())
            {
                Materia ma = new Materia();

                    ma.nombre_materia = txtNombreMateria.Text;
                    bd.Materias.Add(ma);
                    bd.SaveChanges();
                               
                                             
            }
            }
            else
            {
                MessageBox.Show("No se aceptan valores vacios");
            }
            Limpiar();
            cargar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNombreMateria.Text != "")
            {
                using (REGISTROEntities bd = new REGISTROEntities())
                {
                    Materia ma = new Materia();
                    string id = dgvMaterias.CurrentRow.Cells[0].Value.ToString();
                    int idc = int.Parse(id);
                    ma = bd.Materias.Where(VerificarId => VerificarId.Id_materia == idc).First();
                    ma.nombre_materia = txtNombreMateria.Text;
                    bd.Entry(ma).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("No se aceptan valores vacios");
            }
            
            Limpiar();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombreMateria.Text != "")
            {
                using (REGISTROEntities bd = new REGISTROEntities())
                {
                    Materia ma = new Materia();
                    string id = dgvMaterias.CurrentRow.Cells[0].Value.ToString();

                    ma = bd.Materias.Find(int.Parse(id));
                    bd.Materias.Remove(ma);
                    bd.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("No se aceptan valores vacios");
            }

            Limpiar();
            cargar();
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMaterias_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            using (REGISTROEntities bd = new REGISTROEntities())
            {
                var lista = from materias in bd.Materias


                            select new
                            {
                                ID = materias.Id_materia,
                                NOMBRE = materias.nombre_materia

                            };

                dgvMaterias.DataSource = lista.ToList();
            }
        }

        private void cbGuardado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGuardado.CheckState == CheckState.Checked)
            {
                txtNombreMateria.Enabled = true;
                btnGuardar.Enabled = true;
                
            }
            else if (cbGuardado.CheckState == CheckState.Unchecked)
            {
                if (cbOpciones.CheckState == CheckState.Checked)
                {
                    txtNombreMateria.Enabled = true;
                    btnGuardar.Enabled = false;
                }
                else if (cbGuardado.CheckState == CheckState.Unchecked)
                {
                    txtNombreMateria.Enabled = false;
                    btnGuardar.Enabled = false;
                }

            }
        }

        private void cbOpciones_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOpciones.CheckState == CheckState.Checked)
            {
                txtNombreMateria.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else if (cbOpciones.CheckState == CheckState.Unchecked)
            {
                if (cbGuardado.CheckState == CheckState.Checked)
                {
                    txtNombreMateria.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else if (cbGuardado.CheckState == CheckState.Unchecked)
                {
                    txtNombreMateria.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                
            }
        }

        private void cbLimpiar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLimpiar.CheckState == CheckState.Checked)
            {
                Limpiar();
            }
        }
    }
}
