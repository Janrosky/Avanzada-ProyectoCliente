using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using ProyectoCliente;
/*
 Proyecto 2 UNED I Cuatrimestre 2024
Elaborado por: Alejandro Chacon Garita
Referencias: 
C# Lock Multithreading/tasks. (2020). Aram Yako. https://youtu.be/Y8Go3c-brcg?si=iiRx_6H8zqWk3hbk
¿Qué son los delegados? ¿Para qué sirven los delegados? C# .Net. (2019). hdeleon.net. https://www.youtube.com/watch?v=8e_z_4SwrRc
Sesión Virtual N2 - Programación avanzada - I Cuatrimestre 2024. (2024a). Cátedra Tecnología de Sistemas Juan Gabriel Ramírez Valladares. https://www.youtube.com/watch?v=8RhEv3F94dk
Sesión Virtual N2 - Programación avanzada - I Cuatrimestre 2024. (2024b). Cátedra Tecnología de Sistemas Johan Manuel Acosta Ibáñez. https://youtu.be/3v5vbf-5X4M?si=w51PA36Yoz0INUUE
*/

namespace CapaPresentacion
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        //Se instancia la clase RealizarPedido
        RealizarPedido realizarPedido = new RealizarPedido();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarPedidosPorCliente(Login.idCliente);
            CalcularTotalPrecio();
        }

        private void CargarPedidosPorCliente(string idCliente)
        {
            //Se crea una lista de pedidos por cliente y se obtiene mediante el controlador
            List<Pedido> pedidosPorCliente = ControladorClienteTCP.ObtenerPedidosPorCliente(idCliente);

            //Se definen las columnas del datagridview
            dgvPedido.Rows.Clear();
            dgvPedido.Columns.Clear();
            dgvPedido.Columns.Add("IdArticulo", "IdArticulo");
            dgvPedido.Columns.Add("NombreCliente", "Nombre Cliente");
            dgvPedido.Columns.Add("Precio", "Precio");
            dgvPedido.Columns.Add("IdPedido", "Id Pedido");
            dgvPedido.Columns.Add("FechaPedido", "Fecha Pedido");

            //Se recorre la lista de pedidos por cliente y se llenan las filas del datagridview
            foreach (Pedido pedido in pedidosPorCliente)
            {
                Articulo articulo = ControladorClienteTCP.ObtenerArticuloPorId(pedido.IdArticulo);
                int precio = articulo.Precio;
                //Se agregan las filas al datagridview
                dgvPedido.Rows.Add(pedido.IdArticulo, Login.nombreCliente, precio, pedido.IdPedido, pedido.Fecha);
            }
        }

        private void CargarPedidosPorId(string idCliente)
        {
            try
            {
                // Verificar si el TextBox está vacío
                if (string.IsNullOrEmpty(txtIdPedido.Text))
                {
                    MessageBox.Show("Por favor ingrese un ID de pedido.");
                    return;
                }

                // Se crea una lista de pedidos por cliente y se obtiene mediante el controlador
                List<Pedido> pedidosPorCliente = ControladorClienteTCP.ObtenerPedidosPorCliente(idCliente);

                int idPedido = Convert.ToInt32(txtIdPedido.Text);

                // Se definen las columnas del DataGridView
                dgvPedido.Rows.Clear();
                dgvPedido.Columns.Clear();
                dgvPedido.Columns.Add("IdArticulo", "IdArticulo");
                dgvPedido.Columns.Add("NombreCliente", "Nombre Cliente");
                dgvPedido.Columns.Add("Precio", "Precio");
                dgvPedido.Columns.Add("IdPedido", "Id Pedido");
                dgvPedido.Columns.Add("FechaPedido", "Fecha Pedido");

                // Se recorre la lista de pedidos por cliente y se llenan las filas del DataGridView
                foreach (Pedido pedido in pedidosPorCliente)
                {
                    if (pedido.IdPedido == idPedido)
                    {
                        Articulo articulo = ControladorClienteTCP.ObtenerArticuloPorId(pedido.IdArticulo);
                        int precio = articulo.Precio;
                        // Se agregan las filas al DataGridView
                        dgvPedido.Rows.Add(pedido.IdArticulo, Login.nombreCliente, precio, pedido.IdPedido, pedido.Fecha);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos: " + ex.Message);
            }
        }


        private void CalcularTotalPrecio()
        {
            int total = 0;

            foreach (DataGridViewRow fila in dgvPedido.Rows)
            {
                //Se verifica si el valor de la celda no es nulo y es convertible a int
                if (fila.Cells[2].Value != null && int.TryParse(fila.Cells[2].Value.ToString(), out int precio))
                {
                    //Se suma el precio de cada fila al total
                    total += precio;
                }
            }
            //Se establece el total en el label
            lblPrecio.Text = total.ToString();
        }

        private void btnConsultarPorId_Click(object sender, EventArgs e)
        {
            CargarPedidosPorId(Login.idCliente);
        }
    }
}
