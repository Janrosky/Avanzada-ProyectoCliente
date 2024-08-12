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
    public class Cliente
    {
        // Atributos de la clase Cliente
        private string _Identificacion;
        private string _Nombre;
        private string _PrimerApellido;
        private string _SegundoApellido;
        private DateTime _FechaNacimiento;
        private char _Genero;

        // Constructor de la clase Cliente
        public Cliente()
        {
        }
        public Cliente(string identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, char genero)
        {
            _Identificacion = identificacion;
            _Nombre = nombre;
            _PrimerApellido = primerApellido;
            _SegundoApellido = segundoApellido;
            _FechaNacimiento = fechaNacimiento;
            _Genero = genero;
        }

        // Propiedades get y set de la clase Cliente
        public string Identificacion { get => _Identificacion; set => _Identificacion = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string PrimerApellido { get => _PrimerApellido; set => _PrimerApellido = value; }
        public string SegundoApellido { get => _SegundoApellido; set => _SegundoApellido = value; }
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public char Genero { get => _Genero; set => _Genero = value; }
    }
}
