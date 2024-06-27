using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexion : DataConnection
    {

        public Conexion() : base("LocalHouseBD") { }
        
        public ITable<Estudiantes> TblEstudiantes { get { return this.GetTable<Estudiantes>(); } }

   
        

    }
}
