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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
            txtIdEstudiante.Enabled = false;
            txtIdMateria.Enabled = false;
            txtNota.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            
        }

             

        
        Materia ma = new Materia();
        Calificacione no = new Calificacione();
        Estudiante es = new Estudiante();

        void cargar()
        {
            using (REGISTROEntities bd = new REGISTROEntities())
            {
                var union = from es in bd.Estudiantes
                            from no in bd.Calificaciones
                            from ma in bd.Materias
                            where es.Id_estudiante == no.Id_estudiante
                             && ma.Id_materia == no.Id_materia


                            select new
                            {
                                ID_NOTAS = no.Id_notas,
                                NOMBRE_ESTUDIANTE = es.nombre_estudiante,
                                NOMBRE_MATERIA = ma.nombre_materia,
                                NOTA = no.nota

                            };

                dgvNotas.DataSource = union.ToList();
            }
        }

        void limpiar()
        {
            txtIdNotas.Text = "";
            txtIdEstudiante.Text = "";
            txtIdMateria.Text = "";
            txtNota.Text = "";
        }





        private void frmNotas_Load(object sender, EventArgs e)
        {
            using (REGISTROEntities bd = new REGISTROEntities())
            {
                var union = from es in bd.Estudiantes
                            from no in bd.Calificaciones
                            from ma in bd.Materias
                            where es.Id_estudiante == no.Id_estudiante
                            && ma.Id_materia == no.Id_materia
                            

                            select new
                            {
                                ID_NOTAS = no.Id_notas,
                                NOMBRE_ESTUDIANTE = es.nombre_estudiante,
                                NOMBRE_MATERIA = ma.nombre_materia,
                                NOTA = no.nota

                            };
                dgvNotas.DataSource = union.ToList();

            }
            cargar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdEstudiante.Text != "" && txtIdMateria.Text != "" && txtNota.Text != "")
            {
                using (REGISTROEntities bd = new REGISTROEntities())
                {
                    Calificacione no = new Calificacione();

                    no.nota = int.Parse(txtNota.Text);
                    no.Id_estudiante = int.Parse(txtIdEstudiante.Text);
                    no.Id_materia = int.Parse(txtIdMateria.Text);
                    bd.Calificaciones.Add(no);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIdEstudiante.Text != "" && txtIdMateria.Text != "" && txtNota.Text != "")
            {
                using (REGISTROEntities bd = new REGISTROEntities())
                {
                    string id = dgvNotas.CurrentRow.Cells[0].Value.ToString();
                    int id2 = int.Parse(id);
                    no = bd.Calificaciones.Where(verificarId => verificarId.Id_notas == id2).First();
                    no.Id_estudiante = int.Parse(txtIdEstudiante.Text);
                    no.Id_materia = int.Parse(txtIdMateria.Text);
                    no.nota = decimal.Parse(txtNota.Text);
                    bd.Entry(no).State = System.Data.Entity.EntityState.Modified;
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

        private void dgvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (REGISTROEntities bd = new REGISTROEntities())
            {

                string id = dgvNotas.CurrentRow.Cells[0].Value.ToString();
                int id2 = int.Parse(id);
                no = bd.Calificaciones.Where(verificarId => verificarId.Id_notas == id2).First();
                txtIdEstudiante.Text = Convert.ToString(no.Id_estudiante);
                txtIdNotas.Text = Convert.ToString(no.Id_notas);
                txtIdMateria.Text = Convert.ToString(no.Id_materia);
                txtNota.Text = Convert.ToString(no.nota);

                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdEstudiante.Text != "" && txtIdMateria.Text != "" && txtNota.Text != "")
            {
                using (REGISTROEntities bd = new REGISTROEntities())
                {
                    Calificacione no = new Calificacione();

                    string id = dgvNotas.CurrentRow.Cells[0].Value.ToString();
                    int id1 = int.Parse(id);
                    no = bd.Calificaciones.Where(verificarId => verificarId.Id_notas == id1).First();
                    bd.Entry(no).State = System.Data.Entity.EntityState.Deleted;
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
                txtIdEstudiante.Enabled = true;
                txtIdMateria.Enabled = true;
                txtNota.Enabled = true;
                btnGuardar.Enabled = true;
            }
            else if (cbGuardado.CheckState == CheckState.Unchecked)
            {
                if (cbOpciones.CheckState == CheckState.Checked)
                {
                    txtIdEstudiante.Enabled = true;
                    txtIdMateria.Enabled = true;
                    txtNota.Enabled = true;
                    btnGuardar.Enabled = false;
                }
                else if (cbOpciones.CheckState == CheckState.Unchecked)
                {
                    txtIdEstudiante.Enabled = false;
                    txtIdMateria.Enabled = false;
                    txtNota.Enabled = false;
                    btnGuardar.Enabled = false;
                }
                
            }
        }

        private void cbOpciones_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOpciones.CheckState == CheckState.Checked)
            {
                txtIdEstudiante.Enabled = true;
                txtIdMateria.Enabled = true;
                txtNota.Enabled = true;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                
            }
            else if (cbOpciones.CheckState == CheckState.Unchecked)
            {
                if (cbGuardado.CheckState == CheckState.Checked)
                {
                    txtIdEstudiante.Enabled = true;
                    txtIdMateria.Enabled = true;
                    txtNota.Enabled = true;
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else if (cbGuardado.CheckState == CheckState.Unchecked)
                {
                    txtIdEstudiante.Enabled = false;
                    txtIdMateria.Enabled = false;
                    txtNota.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnEliminar.Enabled = false;
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
