using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using Newtonsoft.Json;
using System.IO;
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
    public class ControladorClienteTCP
    {
        private static TcpClient cliente;
        private static IPEndPoint serverEndPoint;
        private static StreamWriter clienteStreamWriter;
        private static StreamReader clienteStreamReader;

        //---------METODOS DE CONEXIÓN Y DESCONEXIÓN---------
        public static bool Conectar(string identificacion)
        {
            try
            {
                IPAddress local = IPAddress.Parse("127.0.0.1"); //Se define la IP del server
                cliente = new TcpClient(); //Se crea un objeto de tipo TcpClient que se conectará al servidor
                serverEndPoint = new IPEndPoint(local, 13200); //Se indica el puerto del servidor al que se conectará el cliente
                cliente.Connect(serverEndPoint);

                //Se envía un mensaje de conexión al servidor
                MensajeSocket<string> mensajeConectar = new MensajeSocket<string> { Metodo = "Conectar", Entidad = identificacion};
                
                //Se crean los objetos de tipo StreamWriter y StreamReader para enviar y recibir mensajes
                clienteStreamReader = new StreamReader(cliente.GetStream());
                clienteStreamWriter = new StreamWriter(cliente.GetStream());

                //Se envian el mensaje de conexión al servidor mediante el StreamWriter
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeConectar));
                //El flush envía los datos inmediatamente
                clienteStreamWriter.Flush();


            }
            catch (SocketException)
            {
                return false;
            }
            return true;
        }

        public static void Desconectar(string identificacion)
        {
            try
            {
                MensajeSocket<string> mensajeDesconectar = new MensajeSocket<string> { Metodo = "Desconectar", Entidad = identificacion };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeDesconectar));
                clienteStreamWriter.Flush();
            }
            catch (SocketException)
            {
                throw;
            }

        }

        //---------MÉTODO PARA VERIFICAR QUE EL CLIENTE EXISTE Y CONECTARLO---------
        public static bool ConectarYVerificarCliente(string identificacion)
        {
            try
            {
                //Se verifica si el método Conectar fue exitoso
                bool conexionExitosa = Conectar(identificacion);
                //Si no se pudo conectar, se retorna false
                if (!conexionExitosa)
                {
                    return false;
                }

                //Se envía un mensaje de verificación al servidor
                MensajeSocket<string> mensajeVerificarCliente = new MensajeSocket<string> { Metodo = "VerificarCliente", Entidad = identificacion };

                //Se envian el mensaje de verificación al servidor mediante el StreamWriter
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeVerificarCliente));
                //El flush envía los datos inmediatamente
                clienteStreamWriter.Flush();

                //Se lee la respuesta del servidor mediante el StreamReader
                var mensaje = clienteStreamReader.ReadLine();
                //Se convierte el mensaje en uno de tipo bool
                bool clienteExiste = JsonConvert.DeserializeObject<bool>(mensaje);

                //Si el cliente no existe, se procede a desconectarlo
                if (!clienteExiste)
                {
                    Desconectar(identificacion);
                }

                //Si el cliente existe, se retorna true
                return clienteExiste;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static Cliente ObtenerCliente(String identificacion)
        {
            try
            {
                // Verificar si los objetos clienteStreamWriter y clienteStreamReader son nulos
                if (clienteStreamWriter == null || clienteStreamReader == null)
                {
                    throw new InvalidOperationException("El servidor no está encendido");
                }

                //Se envía un mensaje al servidor para obtener un cliente
                MensajeSocket<string> mensajeObtenerCliente = new MensajeSocket<string> { Metodo = "ObtenerCliente", Entidad = identificacion };

                //Se envian el mensaje de obtener cliente al servidor mediante el StreamWriter
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerCliente));
                //El flush envía los datos inmediatamente
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                Cliente cliente = JsonConvert.DeserializeObject<Cliente>(mensaje);

                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }


        //--------Metodo para obtener articulosPorHotel
        public static List<ArticuloHotel> ObtenerArticulosPorHotel(int idHotel)
        {
            try
            {       

                MensajeSocket<int> mensajeObtenerArticulos = new MensajeSocket<int> { Metodo = "ObtenerArticulosPorHotel", Entidad = idHotel };        
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerArticulos));
                clienteStreamWriter.Flush();

                // Leer la respuesta del servidor y convertirla en una lista de artículos
                var mensaje = clienteStreamReader.ReadLine();
                List<ArticuloHotel> articulos = JsonConvert.DeserializeObject<List<ArticuloHotel>>(mensaje);

                return articulos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Metodo para obtener articulos por Id
        public static Articulo ObtenerArticuloPorId(int idArticulo)
        {
            try
            {

                MensajeSocket<int> mensajeObtenerArticulo = new MensajeSocket<int> { Metodo = "ObtenerArticuloPorId", Entidad = idArticulo };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerArticulo));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                Articulo articulo = JsonConvert.DeserializeObject<Articulo>(mensaje);

                return articulo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //--------Metodo para obtener Categoria por Id
        public static Categoria ObtenerCategoriaPorId(int pIdCategoria)
        {
            try
            {

                MensajeSocket<int> mensajeObtenerCategoria = new MensajeSocket<int> { Metodo = "ObtenerCategoriaPorId", Entidad = pIdCategoria };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerCategoria));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                Categoria categoria = JsonConvert.DeserializeObject<Categoria>(mensaje);

                return categoria;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int ObtenerIdPedido() 
        {
            try
            {
                MensajeSocket<string> mensajeObtenerIdPedido = new MensajeSocket<string> { Metodo = "ObtenerIdPedido" };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerIdPedido));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                int idPedido = JsonConvert.DeserializeObject<int>(mensaje);
                return idPedido;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Buscar Id de Hotel por nombre del Hotel
        public static int ObtenerIdHotel(string nombreHotel)
        {
            try
            {

                MensajeSocket<string> mensajeObtenerIdHotel = new MensajeSocket<string> { Metodo = "ObtenerIdHotel", Entidad = nombreHotel };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerIdHotel));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                int idHotel = JsonConvert.DeserializeObject<int>(mensaje);

                return idHotel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Buscar hoteles
        public static List<string> ObtenerHoteles()
        {
            List<string> hoteles = new List<string>();
            try
            {
                MensajeSocket<string> mensajeObtenerHoteles = new MensajeSocket<string> { Metodo = "ObtenerHoteles" };

                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerHoteles));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                hoteles = JsonConvert.DeserializeObject<List<string>>(mensaje);

                return hoteles;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Metodo para Agregar Pedido
        public static bool AgregarPedido(Pedido pedido)
        {
            try
            {
                MensajeSocket<Pedido> mensajeAgregarPedido = new MensajeSocket<Pedido> { Metodo = "AgregarPedido", Entidad = pedido };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeAgregarPedido));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                bool pedidoAgregado = JsonConvert.DeserializeObject<bool>(mensaje);
                return pedidoAgregado;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        //Metodo para obtener pedidos por cliente
        public static List<Pedido> ObtenerPedidosPorCliente(string idCliente)
        {
            List<Pedido> pedidos = new List<Pedido>();
            try
            {
                if (string.IsNullOrEmpty(idCliente))
                {
                    throw new ArgumentNullException(nameof(idCliente), "El ID del cliente no puede ser nulo o vacío.");
                }

                MensajeSocket<string> mensajeObtenerPedidos = new MensajeSocket<string> { Metodo = "ObtenerPedidosPorCliente", Entidad = idCliente };
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeObtenerPedidos));
                clienteStreamWriter.Flush();

                var mensaje = clienteStreamReader.ReadLine();
                pedidos = JsonConvert.DeserializeObject<List<Pedido>>(mensaje);

                return pedidos;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return pedidos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener pedidos: " + ex.Message);
                return pedidos;
            }
        }


    }
}
