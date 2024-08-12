using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
/*
 Proyecto 2 UNED I Cuatrimestre 2024
Elaborado por: Alejandro Chacon Garita
Referencias: 
C# Lock Multithreading/tasks. (2020). Aram Yako. https://youtu.be/Y8Go3c-brcg?si=iiRx_6H8zqWk3hbk
¿Qué son los delegados? ¿Para qué sirven los delegados? C# .Net. (2019). hdeleon.net. https://www.youtube.com/watch?v=8e_z_4SwrRc
Sesión Virtual N2 - Programación avanzada - I Cuatrimestre 2024. (2024a). Cátedra Tecnología de Sistemas Juan Gabriel Ramírez Valladares. https://www.youtube.com/watch?v=8RhEv3F94dk
Sesión Virtual N2 - Programación avanzada - I Cuatrimestre 2024. (2024b). Cátedra Tecnología de Sistemas Johan Manuel Acosta Ibáñez. https://youtu.be/3v5vbf-5X4M?si=w51PA36Yoz0INUUE
*/
namespace CapaEntidades
{
    [Serializable]
    public class Pedido
    {
        private int _IdPedido;
        private int _IdArticulo;
        private String _IdCliente;
        private DateTime _Fecha;

        public Pedido()
        {
        }

        public Pedido(int idPedido, int idArticulo, String idCliente, DateTime fecha)
        {
            _IdPedido = idPedido;
            _IdArticulo = idArticulo;
            _IdCliente = idCliente;
            _Fecha = fecha;
        }

        public int IdPedido { get => _IdPedido; set => _IdPedido = value; }
        public int IdArticulo { get => _IdArticulo; set => _IdArticulo = value; }
        public String IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
    }
}
