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
    public partial class AgregarAfiliado : Form
    {
        public AgregarAfiliado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //leyendo datos de los TextBox
            String PNombre = txtPNombre.Text;
            String SNombre = txtSNombre.Text;
            String PApellido = txtPApellido.Text;
            String SApellido = txtSAPellido.Text;
            String Correo1 = txtCorreo1.Text;
            String Correo2 = txtCorreo2.Text;
            String Calle = txtCalle.Text;
            String Avenida = txtAvenida.Text;
            String NCasa = txtNCasa.Text;
            String Ciudad = txtCiudad.Text;
            String Depar = txtDepar.Text;
            String Refer = txtRef.Text;
            String Fecha = txtFecha.Text;
            String Telefono = txtTelefono.Text;
            String Usuario = txtUsuario.Text;
            String Pass = txtPass.Text;
            String usuario = txtUsuario.Text;
            String pass = txtPass.Text;

            OdbcConnection DbConnection = new OdbcConnection("Dsn=ProyectoTBD1;uid=sysdba;pwd=1234");
            DbConnection.Open();
            OdbcCommand DbCommand = DbConnection.CreateCommand();
            DbCommand.CommandText = "execute procedure SP_AFILIADOS_CREATE('00'," +
                "'"+Correo1+"','"+Correo2+"','15.10.1999','"+Fecha+"','"+Avenida+"','"
                +Calle+"','"+Refer+"','"+Depar+"','"+Ciudad+"','"+NCasa+"','"+PNombre+"','"
                +SNombre+"','"+PApellido+"','"+SApellido+"','v',0,'15.10.1999',0,'v',0,0,'15.10.1999')";

            OdbcDataReader DbReader = DbCommand.ExecuteReader();

            
            DbReader.Close();

            DbCommand.CommandText = "execute procedure SP_USUARIOS_CREATE('"+Usuario+"','"+Pass+"',0)";
            DbReader = DbCommand.ExecuteReader();




            DbConnection.Close();
            this.Close();
        }
    }
}
