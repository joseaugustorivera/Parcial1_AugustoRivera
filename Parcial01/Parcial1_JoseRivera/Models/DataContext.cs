using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial1_JoseRivera.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }
    }
}