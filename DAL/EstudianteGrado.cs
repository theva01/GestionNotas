using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EstudianteGrado
    {
        [PrimaryKey]
        public int EstudianteID { get; set; }
            
        [PrimaryKey]
        public int GradoID { get; set; }
    }
}
