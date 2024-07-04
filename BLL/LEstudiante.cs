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
    public class LEstudiante : Conexion
    {
        private List<TextBox> listaDeTxt;

        public LEstudiante(List<TextBox> listaDeTxt)
        {
            this.listaDeTxt = listaDeTxt;
        }

        public void Registrar()
        {
            
            var user = TblEstudiantes.Where(u => u.Correo.Equals(listaDeTxt[3].Text)).ToList();
            if (user.Count.Equals(0))
            {
                BeginTransactionAsync();
                try
                {
                    //metodo de Insertar 2
                    TblEstudiantes
                    .Value(e => e.NumeroId, listaDeTxt[0].Text)
                    .Value(e => e.Nombre, listaDeTxt[1].Text)
                    .Value(e => e.Apellido, listaDeTxt[2].Text)
                    .Value(e => e.Correo, listaDeTxt[3].Text)
                    .Value(e => e.FechaNacimiento, Convert.ToDateTime(listaDeTxt[4].Text))
                    .Value(e => e.Direccion, listaDeTxt[5].Text)
                    .Value(e => e.Telefono, listaDeTxt[6].Text)
                    .Insert();

                    CommitTransaction();
                }
                catch (Exception)
                {

                    RollbackTransaction();
                }
            }

            //metodo De Insertar 1
            //var db = new Conexion();
            //db.Insert(new Estudiantes() {
            //    NumeroId = listaDeTxt[0].Text,
            //    Nombre = listaDeTxt[1].Text,
            //    Apellido = listaDeTxt[2].Text,
            //    Correo = listaDeTxt[3].Text,
            //    FechaNacimiento = Convert.ToDateTime(listaDeTxt[4].Text),
            //    Direccion = listaDeTxt[5].Text,
            //    Telefono = listaDeTxt[6].Text,

            //});

        }


    }
}
