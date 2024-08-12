using CapaEntidades;
using ProyectoCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class RealizarPedido : Form
    {
        public RealizarPedido()
        {
            InitializeComponent();
            lblUsuario.Text = Login.nombreCliente; //Se muestra el nombre del cliente en el label
            LlenarCBHotel(); //Se llena el combobox con los hoteles disponibles
        }

        private void CalcularTotalPrecio()
        {
            int total = 0;

            foreach (DataGridViewRow fila in dgvSeleccion.Rows)
            {
                // Verificar si el valor de la celda no es nulo y es convertible a entero
                if (fila.Cells[2].Value != null && int.TryParse(fila.Cells[2].Value.ToString(), out int precio))
                {
                    total += precio;
                }
            }
            lblPrecio.Text = total.ToString();
        }

        private void LlenarCBHotel()
        {
            //Se crea una lista de tipo String con los nombres de los hoteles disponibles y se obtiene mediante el controlador
            List<string> hoteles = ControladorClienteTCP.ObtenerHoteles();
            cbHoteles.DataSource = hoteles;
        }

        private void CargarArticulosPorHotel(int idHotel)
        {
            //Se crea una lista de articulos por hotel y se obtiene mediante el controlador
            List<ArticuloHotel> articulosPorHotel = ControladorClienteTCP.ObtenerArticulosPorHotel(idHotel);

            //Se definen las columnas del datagridview
            dgvArticulos.Columns.Clear();
            dgvArticulos.Columns.Add("IdArticulo", "IdArticulo");
            dgvArticulos.Columns.Add("Nombre", "Nombre");
            dgvArticulos.Columns.Add("Precio", "Precio");
            dgvArticulos.Columns.Add("IdCategoria", "IdCategoria");
            dgvArticulos.Columns.Add("Categoria", "Descripcion Categoría");
            dgvArticulos.AllowUserToAddRows = false;
            // Limpia las filas existentes en el DataGridView
            dgvArticulos.Rows.Clear();

            //Se recorre la lista de articulos por hotel y se llenan las filas del datagridview
            foreach (ArticuloHotel articuloHotel in articulosPorHotel)
            {
                Articulo articulo = ControladorClienteTCP.ObtenerArticuloPorId(articuloHotel.IdArticulo);
                if (articulo != null)
                {
                    dgvArticulos.Rows.Add(articulo.IdArticulo, articulo.Nombre, articulo.Precio, articulo.Categoria.IdCategoria, articulo.Categoria.Descripcion);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Verificar si el DataGridView de selección ya tiene columnas
            if (dgvSeleccion.Columns.Count == 0)
            {
                //Se recorre las columnas del datagridview de articulos
                foreach (DataGridViewColumn columnaOrigen in dgvArticulos.Columns)
                {
                    //Se copian las columnas al datagridview de selección
                    dgvSeleccion.Columns.Add((DataGridViewColumn)columnaOrigen.Clone());
                }
            }
            //Metodo que permite copiar las filas seleccionadas del datagridview de articulos al datagridview de selección
            CopiarFilasSeleccionadas(dgvArticulos, dgvSeleccion);
            CalcularTotalPrecio();
        }

        public List<Articulo> seleccionArticulos()
        {
            //Se crea una lista de objetos de tipo Articulo
            List<Articulo> arreglo = new List<Articulo>();

            //Se recorren las filas del datagridview de seleccion
            foreach (DataGridViewRow fila in dgvSeleccion.Rows)
            {
                //Se obtienen los datos de cada fila para luego agregarlos al arreglo
                int idArticulo = Convert.ToInt32(fila.Cells[0].Value);
                string nombre = (string)fila.Cells[1].Value;
                int precio = Convert.ToInt32(fila.Cells[2].Value);
                int idCategoria = Convert.ToInt32(fila.Cells[3].Value);
                string descripcionCategoria = (string)fila.Cells[4].Value;
                Categoria categoria = ControladorClienteTCP.ObtenerCategoriaPorId(idCategoria);
                //Se crea un objeto de tipo Articulo
                Articulo articulo = new Articulo(idArticulo, nombre, precio, categoria);
                //Se agrega el articulo al arreglo
                arreglo.Add(articulo);
            }
            //Se retorna el arreglo con todos los articulos seleccionados para agregar al hotel
            return arreglo;
        }

        private void CopiarFilasSeleccionadas(DataGridView dgvOrigen, DataGridView dgvDestino)
        {
            //Se recorren las filas seleccionadas del datagridview de origen
            foreach (DataGridViewRow filaSeleccionada in dgvOrigen.SelectedRows)
            {
                // Se crea una nueva fila en el DataGridView de destino
                DataGridViewRow nuevaFila = (DataGridViewRow)filaSeleccionada.Clone();

                // Se copian los valores de la celda seleccionada a la nueva fila
                for (int i = 0; i < filaSeleccionada.Cells.Count; i++)
                {
                    nuevaFila.Cells[i].Value = filaSeleccionada.Cells[i].Value;
                }

                // La nueva fila es añadida al DataGridView de destino
                dgvDestino.Rows.Add(nuevaFila);
            }
        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {

            try
            {
                //Se crea una lista con los articulos seleccionados
                List<Articulo> arreglo = seleccionArticulos();

                // Se verifica si el campo de texto txtIdPedido esta vacío

                //Se obtienen los datos ingresados para luego guardarlos
                String idCliente = Login.idCliente;
                DateTime fecha = dtp.Value;
                //Se recorre el arreglo de articulos
                foreach (Articulo articulo in arreglo)
                {
                    //Se obtienen los datos para guardar el pedido
                    int idArticulo = articulo.IdArticulo;
                    int idPedido = ControladorClienteTCP.ObtenerIdPedido();
                    Pedido pedido = new Pedido(idPedido, idArticulo, idCliente, fecha);
                    //Se guarda el pedido
                    bool exito = ControladorClienteTCP.AgregarPedido(pedido);
                    if (exito)
                    {
                        MessageBox.Show("Pedido guardado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error, el primary key puede estar repetido");
                    }
                }
                LimpiarTablaSeleccion();
            }
            catch (Exception)
            {

                throw;
            }
        
        }

        private void LimpiarTablaSeleccion()
        {
            dgvSeleccion.Rows.Clear();
            dgvSeleccion.Columns.Clear();
        }

        private void cbHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHoteles.SelectedItem != null && cbHoteles.SelectedItem is string)
            {
                string nombreHotel = cbHoteles.SelectedItem.ToString();
                int idHotel = ControladorClienteTCP.ObtenerIdHotel(nombreHotel);
                if (idHotel != -1)
                {
                    CargarArticulosPorHotel(idHotel);
                }
                else
                {
                    MessageBox.Show("Hotel no encontrado.");
                }
            }
        }
    }
}
