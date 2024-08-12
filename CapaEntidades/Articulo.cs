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
    public class Articulo
    {
        // Atributos de la clase Articulo
        private int _IdArticulo;
        private string _Nombre;
        private int _Precio;
        private Categoria _Categoria;

        // Constructor de la clase Articulo
        public Articulo(int idArticulo, string nombre, int precio, Categoria categoria)
        {
            _IdArticulo = idArticulo;
            _Nombre = nombre;
            _Precio = precio;
            _Categoria = categoria;
        }

        // Propiedades get y set de la clase Articulo
        public int IdArticulo { get => _IdArticulo; set => _IdArticulo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int Precio { get => _Precio; set => _Precio = value; }
        public Categoria Categoria { get => _Categoria; set => _Categoria = value; }

    }
}
