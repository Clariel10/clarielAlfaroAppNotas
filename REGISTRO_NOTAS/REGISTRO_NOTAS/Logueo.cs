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
using REGISTRO_NOTAS.VISTAS;

namespace REGISTRO_NOTAS
{
    public partial class Logueo : Form
    {
        public Logueo()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (REGISTROEntities bd = new REGISTROEntities()) {

                var acceso = from es in bd.Estudiantes
                             where es.usuario == txtUsuario.Text
                             && es.contraseña == txtContra.Text
                             select es;

                if (acceso.Count() > 0) { 

                frmMenu menu = new frmMenu();
                menu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("  Datos ingresados\n" +
                        "     no existentes");
                }
               
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           

            if (checkBox1.CheckState == CheckState.Checked)
            {
                txtContra.UseSystemPasswordChar = false;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtContra.UseSystemPasswordChar = true;
            }

        }

        private void Logueo_Load(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
