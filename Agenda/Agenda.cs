using AgendaBE;
using System;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Agenda : Form
    {
        NuevoContacto MyNuevoContacto = new NuevoContacto();

        private Contactos contactos = new Contactos();
        public Agenda()
        {
            InitializeComponent();
            dataGridView1.DataSource = contactos.ListaDT;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            




            decimal verificacion;



            if (txtTelefono.Text == "")
            {

                errorProvider1.SetError(txtTelefono, "error ingrese un valor");
                txtTelefono.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtTelefono, "");
                if (!Decimal.TryParse(txtTelefono.Text, out verificacion))
                {
                    errorProvider1.SetError(txtTelefono, "ingrese numeros");
                    return;
                }
                else
                {
                    NuevoContacto Contacto = new NuevoContacto();
                    errorProvider1.SetError(txtTelefono, "");
                    Contacto.Agregar(txtNombre.Text,
                    txtTelefono.Text,
                    txtMail.Text);
                    contactos.InsertContacto(Contacto);
                    dataGridView1.DataSource = contactos.ListaDT;


                }
            }

            

        }


        private void btnContactos_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            btnNuevoContacto.Visible = true;
            btnContactos.Visible = false;
            lblAgenda.Visible = false;
            lblTelefono.Visible = false;
            lblNombre.Visible = false;
            lblEmail.Visible = false;
            txtTelefono.Visible = false;
            txtNombre.Visible = false;
            txtMail.Visible = false;
            btnAgregar.Visible = false;
        }

        private void btnNuevoContacto_Click(object sender, EventArgs e)

        {
            dataGridView1.Visible = false;
            btnNuevoContacto.Visible = false;
            btnContactos.Visible = true;
            lblAgenda.Visible = true;
            lblTelefono.Visible = true;
            lblNombre.Visible = true;
            lblEmail.Visible = true;
            txtTelefono.Visible = true;
            txtNombre.Visible = true;
            txtMail.Visible = true;
            btnAgregar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NuevoContacto cont = contactos.Buscar(txtTelefonoB.Text);

            if (cont.Telefono != 0)
            {
                lblNombreR.Text = cont.Nombre;
                lblTelefonoR.Text = cont.Telefono.ToString();
                lblMailR.Text = cont.Mail;
                lblMailR.Visible = true;
                lblNombreR.Visible = true;
                lblTelefonoR.Visible = true;

                txtNombre.Focus();
            }
            else
            {
                lblNombreR.Visible=false;
                lblMailR.Visible=false;
                lblTelefonoR.Visible=true;
                lblTelefonoR.Text = "no existe";
                txtTelefonoB.SelectAll();
                txtTelefonoB.Focus();
            }
        }

        private void Agenda_Load(object sender, EventArgs e)
        {

        }
    }
}
