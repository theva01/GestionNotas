using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BllEstudianteGrado : Conexion
    {
        private object[] objects;
        private DataGridView dataGridView;

        public BllEstudianteGrado(object[] objects)
        {
            this.objects = objects;
            dataGridView = (DataGridView)objects[0];
        }
    }
}
