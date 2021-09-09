using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_SEMANA_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgData_Click(object sender, EventArgs e)
        {
            // Definir  las columnas 
            Lista.Columns.Add("idStudent", "CODIGO");
            Lista.Columns.Add("firsName", "NOMBRE");
            Lista.Columns.Add("lastName", "APELLIDO");
            Lista.Columns.Add("age", "EDAD");
            Lista.Columns.Add("genero", "GENERO");



            // llenar filas

            foreach (var estudent in selectAllData())
            {
                Lista.Rows.Add(estudent.idStudent, estudent.firsName, estudent.lasName, estudent.age, estudent.genero);
            }

        }

        private List<Estudiantes> selectAllData()
        {
            List<Estudiantes> resul = (

                from student in Estudiantes.GetEstudiantes()
                select new Estudiantes
                {

                    idStudent = student.idStudent,
                    firsName = student.firsName,
                    lasName = student.lasName,
                    age = student.age,
                    genero = student.genero
                }

                ).ToList();

            return resul;
        }
    }
}
