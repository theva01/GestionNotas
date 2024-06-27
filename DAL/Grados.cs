using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Grados
    {
        [PrimaryKey, Identity]
        public int ID { get; set; }
        public string Grado { get; set; }
        public string Grupo { get; set; }
    }
}
