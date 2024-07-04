using DAL;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BllGrado : Conexion
    {
        private List<ComboBox> listaDeCmb;

        public BllGrado(List<ComboBox> listaDeCmb)
        {
            this.listaDeCmb = listaDeCmb;
        }

        public void Registrar()
        {
            var db = new Conexion();

            db.Insert(new Grados() { 
            
                Grado = listaDeCmb[0].Text,
                Grupo = listaDeCmb[1].Text,

            });
        }

    }
}
