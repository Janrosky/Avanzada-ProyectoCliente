﻿    using System;
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
    public class ArticuloHotel
    {
        // Atributos de la clase ArticuloHotel
        private int _IdAsignacion;
        private DateTime _Fecha;
        private int _IdHotel;
        private int _IdArticulo;

        public ArticuloHotel() { 
        }

        public ArticuloHotel( DateTime fecha, int idHotel, int idarticulo)
        {
            IdAsignacion = 0;
            Fecha = fecha;
            IdHotel = idHotel;
            IdArticulo = idarticulo;
        }

        public ArticuloHotel(int idAsignacion, DateTime fecha, int idHotel, int idarticulo)
        {
            IdAsignacion = idAsignacion;
            Fecha = fecha;
            IdHotel = idHotel;
            IdArticulo = idarticulo;
        }

        public int IdAsignacion { get => _IdAsignacion; set => _IdAsignacion = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
        public int IdHotel { get => _IdHotel; set => _IdHotel = value; }
        public int IdArticulo { get => _IdArticulo; set => _IdArticulo = value; }
    }
}
