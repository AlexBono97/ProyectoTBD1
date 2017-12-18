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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String eliminar = txtEliminar.Text;
            OdbcConnection DbConnection = new OdbcConnection("Dsn=ProyectoTBD1;uid=sysdba;pwd=1234");
            DbConnection.Open();
            OdbcCommand DbCommand = DbConnection.CreateCommand();
            DbCommand.CommandText = "execute procedure SP_AFILIADOS_DELETE('"+eliminar+"')";
            OdbcDataReader DbReader = DbCommand.ExecuteReader();

            //actualizando el dbgrid

            

            DbReader.Close();
            DbCommand.Dispose();
            DbConnection.Close();
            this.Close();
        }
    }
}
