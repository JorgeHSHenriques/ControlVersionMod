using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIRISKMANAGER.Entity
{
    public class Perimetros
    {
        public string CreatedBy{ get; set; }

    
        public Perimetros()
        {

        }

        public Perimetros(string createdBy)
        {
            this.CreatedBy = createdBy;
        }
       
    }
}
