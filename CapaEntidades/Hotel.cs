using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public class Hotel
    {
        // Atributos de la clase Hotel
        private int _IdHotel;
        private string _Nombre;
        private string _Direccion;
        private string _Telefono;
        private bool _Estado;

        // Constructor de la clase Hotel
        public Hotel(int idHotel, string nombre, string direccion, bool estado, string telefono)
        {
            _IdHotel = idHotel;
            _Nombre = nombre;
            _Direccion = direccion;
            _Telefono = telefono;
            _Estado = estado;
        }

        // Propiedades get y set de la clase Hotel
        public int IdHotel { get => _IdHotel; set => _IdHotel = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
    }
}
