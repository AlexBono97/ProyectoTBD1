using System;
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
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
            
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pyTBD1.AFILIADOS_CUENTAS' table. You can move, or remove it, as needed.
            this.aFILIADOS_CUENTASTableAdapter.Fill(this.pyTBD1.AFILIADOS_CUENTAS);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar m = new Eliminar();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarAfiliado m = new AgregarAfiliado();
            m.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Inicio m = new Inicio();
            m.Show();
            this.Close();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            OdbcConnection DbConnection = new OdbcConnection("Dsn=ProyectoTBD1;uid=sysdba;pwd=1234");
            DbConnection.Open();
            OdbcCommand DbCommand = DbConnection.CreateCommand();
            DbCommand.CommandText = "SELECT * FROM AFILIADOS_CUENTAS";
            OdbcDataReader DbReader = DbCommand.ExecuteReader();
           
            //actualizando el dbgrid
            
            DataTable tabla = new DataTable();
            tabla.Load(DbReader);
            dbGrid.AutoGenerateColumns = true;
            dbGrid.DataSource = tabla;
            dbGrid.Refresh();

            DbReader.Close();
            DbCommand.Dispose();
            DbConnection.Close();
        }
    }
}
