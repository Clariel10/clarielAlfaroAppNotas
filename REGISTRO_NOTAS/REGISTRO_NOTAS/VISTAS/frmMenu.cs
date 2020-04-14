using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REGISTRO_NOTAS.VISTAS;

namespace REGISTRO_NOTAS.VISTAS
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ingresoDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmMaterias());

            //frmMaterias materias = new frmMaterias();
            //materias.Show();


        }

        private void datosDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmRegistro_Estudiantes());
            //frmRegistro_Estudiantes re = new frmRegistro_Estudiantes();
            //re.Show();


        }

        private void notasDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForms(new frmNotas());

            //frmNotas notas = new frmNotas();
            //notas.Show();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

           
        }

        void AbrirForms (object formhijo)
        {

            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
          

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
    }
}
