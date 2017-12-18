using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace AppTeoriaBD1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String pass = txtPass.Text;

            OdbcConnection DbConnection = new OdbcConnection("Dsn=ProyectoTBD1;uid=sysdba;pwd=1234");
            DbConnection.Open();
            OdbcCommand DbCommand = DbConnection.CreateCommand();
            DbCommand.CommandText = "select * FROM SP_USUARIOS_BUSCAR('"+usuario+"','"+pass+"')";

            OdbcDataReader DbReader = DbCommand.ExecuteReader();
            
            Int16 n = 1;
            Int16 p = 0;
            Int16 s = 0;
            int i = 0;
            while (DbReader.Read())
            {

                //s = (Int16)DbReader[0];
                if ((Int16)DbReader[0]==1)
                {
                    //lanzar ventana de administrador
                    Administracion m = new Administracion();
                    m.Show();
                    this.Close();
                    break;
                }
                
                
            }

            DbCommand.Dispose();
            DbReader.Close();
            DbConnection.Close();
            
            

            
           
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
                //lanzar ventana usuario
                Usuario t = new Usuario();
                t.Show();
                this.Close();

            
        }
    }
}
