using System.Reflection;

namespace GridEmpleado
{
    public partial class Form1 : Form
    {
        string nombre, apellido, numero, cedula;
        int i = 10000;
        public Form1()
        {
            InitializeComponent();


        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {

            nombre = txtbname.Text;
            apellido = txtbapellido.Text;
            cedula = txtbid.Text;
            numero = txtbnumero.Text;
            dtgvresumen.Rows.Add(i + "", nombre, apellido, numero, cedula);
            i += 1;
            limpiar();
            lblresultado1.Visible = true;

        }

        private void limpiar()
        {
            txtbname.Text = string.Empty;
            txtbapellido.Text = string.Empty;
            txtbid.Text = string.Empty;
            txtbnumero.Text = string.Empty;


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            dtgvresumen.Rows.RemoveAt(dtgvresumen.CurrentCell.RowIndex);
        }
    }
}