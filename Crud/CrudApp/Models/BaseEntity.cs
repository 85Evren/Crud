using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Models
{
    // Ortak özellikleri topladığımız entity sınıfmız...
    public class BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual DateTime CreDate { get; set; }
    }
}