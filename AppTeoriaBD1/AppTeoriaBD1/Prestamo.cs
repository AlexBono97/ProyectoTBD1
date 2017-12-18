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
    public partial class Prestamo : Form
    {
        public Prestamo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;

            OdbcConnection DbConnection = new OdbcConnection("Dsn=ProyectoTBD1;uid=sysdba;pwd=1234");
            DbConnection.Open();
            OdbcCommand DbCommand = DbConnection.CreateCommand();
            DbCommand.CommandText = "select * FROM SP_PRESTAMOS_READ()";

            OdbcDataReader DbReader = DbCommand.ExecuteReader();


        }
    }
}
