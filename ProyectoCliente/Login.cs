using CapaEntidades;
using CapaPresentacion;
using static CapaPresentacion.ControladorClienteTCP;
/*
 Proyecto 2 UNED I Cuatrimestre 2024
Elaborado por: Alejandro Chacon Garita
Referencias: 
C# Lock Multithreading/tasks. (2020). Aram Yako. https://youtu.be/Y8Go3c-brcg?si=iiRx_6H8zqWk3hbk
�Qu� son los delegados? �Para qu� sirven los delegados? C# .Net. (2019). hdeleon.net. https://www.youtube.com/watch?v=8e_z_4SwrRc
Sesi�n Virtual N2 - Programaci�n avanzada - I Cuatrimestre 2024. (2024a). C�tedra Tecnolog�a de Sistemas Juan Gabriel Ram�rez Valladares. https://www.youtube.com/watch?v=8RhEv3F94dk
Sesi�n Virtual N2 - Programaci�n avanzada - I Cuatrimestre 2024. (2024b). C�tedra Tecnolog�a de Sistemas Johan Manuel Acosta Ib��ez. https://youtu.be/3v5vbf-5X4M?si=w51PA36Yoz0INUUE
*/

namespace ProyectoCliente
{
    public partial class Login : Form
    {
        public static String idCliente = null; // Variable que almacena la identificaci�n del cliente
        public static String nombreCliente = null; // Variable que almacena el nombre del cliente
        bool clienteConectado = false; //Variable para verificar si el cliente est� conectado
        public Login()
        {
            InitializeComponent();
            //Actualizaci�n de la interfaz
            lblEstado.Text = "Desconectado";
            lblEstado.ForeColor = Color.Red;
            btnDesconectar.Enabled = false;
            btnRealizarPedido.Enabled = false;
            btnConsultarPedido.Enabled = false;
        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            //Se verifica si el cliente est� conectado
            if (clienteConectado)
            {
                //Si el cliente est� conectado, se muestra la ventana de realizar pedido
                RealizarPedido realizarPedido = new RealizarPedido();
                realizarPedido.Show();
            }
            else
            {
                //Si el cliente no est� conectado, se muestra un mensaje de error
                MessageBox.Show("Inicia Sesi�n Primero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {
            if (clienteConectado)
            {
                //Si el cliente est� conectado, se muestra la ventana de consultar
                Consultar consultar = new Consultar();
                consultar.Show();
            }
            else
            {
                //Si el cliente no est� conectado, se muestra un mensaje de error
                MessageBox.Show("Inicia Sesi�n Primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            ControladorClienteTCP.Desconectar(txtIdentificacion.Text); //Se desconecta el cliente
            //Actualizaci�n de la interfaz
            lblEstado.Text = "Desconectado del Servidor";
            lblEstado.ForeColor = Color.Red;
            btnDesconectar.Enabled = false;
            btnConectarse.Enabled = true;
            btnRealizarPedido.Enabled = false;
            btnConsultarPedido.Enabled = false;
            clienteConectado = false;
        }

        private void btnConectarse_Click(object sender, EventArgs e)
        {

            idCliente = txtIdentificacion.Text; //Se actualiza la variable con la identificaci�n del cliente

            try
            {
                //Se intenta conectar y verificar al cliente
                bool clienteVerificado = ControladorClienteTCP.ConectarYVerificarCliente(idCliente);
                Cliente cliente = ControladorClienteTCP.ObtenerCliente(idCliente); //Se obtiene el cliente para mostrar su nombre
                if (cliente != null)
                {
                    nombreCliente = cliente.Nombre + " " + cliente.PrimerApellido + " " + cliente.SegundoApellido; //Se actualiza la variable con el nombre del cliente
                }
                if (clienteVerificado)
                {
                    //Si el cliente existe hay una actualizaci�n de la interfaz
                    lblEstado.Text = "Conectado al servidor";
                    lblEstado.ForeColor = Color.Green;
                    clienteConectado = true;
                    btnConectarse.Enabled = false;
                    btnDesconectar.Enabled = true;
                    clienteConectado = true;
                    lblUsuario.Text = nombreCliente;
                    btnRealizarPedido.Enabled = true;
                    btnConsultarPedido.Enabled = true;
                }
                else
                {
                    //S el cliente no existe o no se pudo conectar al servidor, se muestra un mensaje de error
                    MessageBox.Show("El cliente no existe o no se pudo conectar al servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepci�n que pueda ocurrir durante el proceso de conexi�n y verificaci�n
                MessageBox.Show("El cliente no existe o no se pudo conectar al servidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clienteConectado)
            {
                // Desconectar el cliente del servidor
                ControladorClienteTCP.Desconectar(txtIdentificacion.Text);

                // Actualizar la interfaz
                lblEstado.Text = "Desconectado del Servidor";
                lblEstado.ForeColor = Color.Red;
                btnDesconectar.Enabled = false;
                btnConectarse.Enabled = true;
                btnRealizarPedido.Enabled = false;
                btnConsultarPedido.Enabled = false;
                clienteConectado = false;
            }
        }
    }
}
