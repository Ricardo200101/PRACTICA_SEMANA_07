using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_SEMANA_07
{
    class Estudiantes
    {

        public int idStudent { get; set; }

        public String firsName { get; set; }

        public string lasName { get; set; }

        public int age { get; set; }

        public string genero { get; set;  }

        // Creacion de la coleccion de datos.

        public static List<Estudiantes> GetEstudiantes()
        {
            List<Estudiantes> students = new List<Estudiantes> {
            new Estudiantes { idStudent = 20001, firsName = "Ricardo", lasName = "ALVAREZ", age = 22, genero = "M" },
            new Estudiantes { idStudent = 20002, firsName = "SOFIA", lasName = "LOPEZ", age = 29, genero = "F" },
            new Estudiantes { idStudent = 20003, firsName = "RAFAEL", lasName = "REYES", age = 24, genero = "M"},
            new Estudiantes { idStudent = 20004, firsName = "DONATO", lasName = "SILVA", age = 25, genero = "M"},
            new Estudiantes { idStudent = 20005, firsName = "ALFREDO", lasName = "CLARO", age = 24, genero = "M"},
            new Estudiantes { idStudent = 20007, firsName = "AMANDO", lasName = "SARAVIA", age = 23, genero = "M"},
            new Estudiantes { idStudent = 20008, firsName = "MANUEL", lasName = "QUINTANILLA", age = 21 , genero = "M"},
            new Estudiantes { idStudent = 20008, firsName = "PAULO", lasName = "LONDRA", age = 21 , genero = "M"},

            };

            return students;
        }

    }
}
