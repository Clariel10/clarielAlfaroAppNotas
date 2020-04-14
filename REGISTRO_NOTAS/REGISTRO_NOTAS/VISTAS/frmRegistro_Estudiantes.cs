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
    public partial class frmRegistro_Estudiantes : Form
    {
        public frmRegistro_Estudiantes()
        {
            InitializeComponent();
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtUsuario.Enabled = false;
            txtContra.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUsuario.Text = "";
            txtContra.Text = "";
        }

        void cargar()
        {
            using (REGISTROEntities bd = new REGISTROEntities())
            {

                var lista = from es in bd.Estudiantes

                            select new
                            {
                                ID = es.Id_estudiante,
                                NOMBRE = es.nombre_estudiante,
                                APELLIDO = es.apellido,
                                USUARIO = es.usuario,
                                CONTRASEÑA = es.contraseña
                            };

                dgvEstudiantes.DataSource = lista.ToList();
            }
        }

        private void frmRegistro_Estudiantes_Load(object sender, EventArgs e)
        {
            using (REGISTROEntities bd = new REGISTROEntities())
            {

                var lista = from es in bd.Estudiantes

                            select new
                            {
                                ID = es.Id_estudiante,
                                NOMBRE = es.nombre_estudiante,
                                APELLIDO = es.apellido,
                                USUARIO = es.usuario,
                                CONTRASEÑA = es.contraseña
                            };

                dgvEstudiantes.DataSource = lista.ToList();
            }
            cargar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtUsuario.Text != "" && txtContra.Text != "")
            {
                using (REGISTROEntities bd = new REGISTROEntities())
                {


                    Estudiante es = new Estudiante();

                    es.nombre_estudiante = txtNombre.Text;
                    es.apellido = txtApellido.Text;
                    es.usuario = txtUsuario.Text;
                    es.contraseña = txtContra.Text;

                    bd.Estudiantes.Add(es);
                    bd.SaveChanges();


                }
            }
            else
            {
                MessageBox.Show("No se aceptan valores vacios");
            }

            cargar();
            limpiar();
        }

        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (REGISTROEntities bd = new REGISTROEntities())
            {
                string nombre =  dgvEstudiantes.CurrentRow.Cells[1].Value.ToString();
                string apellido = dgvEstudiantes.CurrentRow.Cells[2].Value.ToString();
                string usuario = dgvEstudiantes.CurrentRow.Cells[3].Value.ToString();
                string contra = dgvEstudiantes.CurrentRow.Cells[4].Value.ToString();

                txtNombre.Text = nombre;
                txtApellido.Text = apellido;
                txtUsuario.Text = usuario;
                txtContra.Text = contra;

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtUsuario.Text != "" && txtContra.Text != "")
            {
                using (REGISTROEntities bd = new REGISTROEntities())
                {
                    Estudiante es = new Estudiante();

                    string id = dgvEstudiantes.CurrentRow.Cells[0].Value.ToString();
                    int id2 = int.Parse(id);
                    es = bd.Estudiantes.Where(verificarId => verificarId.Id_estudiante == id2).First();
                    es.nombre_estudiante = txtNombre.Text;
                    es.apellido = txtApellido.Text;
                    es.usuario = txtUsuario.Text;
                    es.contraseña = txtContra.Text;
                    bd.Entry(es).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();

                }
            }
            else
            {
                MessageBox.Show("No se aceptan valores vacios");
            }


            cargar();
            limpiar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtUsuario.Text != "" && txtContra.Text != "")
            {
                using (REGISTROEntities bd = new REGISTROEntities())
                {
                    Estudiante es = new Estudiante();

                    string id = dgvEstudiantes.CurrentRow.Cells[0].Value.ToString();
                    int id1 = int.Parse(id);
                    es = bd.Estudiantes.Where(verificarId => verificarId.Id_estudiante == id1).First();
                    bd.Entry(es).State = System.Data.Entity.EntityState.Deleted;
                    bd.SaveChanges();

                }
            }
            else
            {
                MessageBox.Show("No se aceptan valores vacios");
            }
           

            cargar();
            limpiar();
        }

        private void cbGuardado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGuardado.CheckState == CheckState.Checked)
            {
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtUsuario.Enabled = true;
                txtContra.Enabled = true;
                btnGuardar.Enabled = true;
                
            }
            else if (cbGuardado.CheckState == CheckState.Unchecked)
            {
                if (cbOpciones.CheckState == CheckState.Checked)
                {
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtContra.Enabled = true;
                    btnGuardar.Enabled = false;
                }
                else if (cbOpciones.CheckState == CheckState.Unchecked)
                {
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtContra.Enabled = false;
                    btnGuardar.Enabled = false;
                }
               
            }
        }

        private void cbOpciones_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOpciones.CheckState == CheckState.Checked)
            {
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtUsuario.Enabled = true;
                txtContra.Enabled = true;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else if (cbOpciones.CheckState == CheckState.Unchecked)
            {
                if (cbGuardado.CheckState == CheckState.Checked)
                {
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtContra.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                }
                else if (cbGuardado.CheckState == CheckState.Unchecked)
                {
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtUsuario.Enabled = false;
                    txtContra.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnActualizar.Enabled = false;
                }
                
            }
        }

        private void cbLimpiar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLimpiar.CheckState == CheckState.Checked)
            {
                limpiar();
            }
            
        }
    }
}
