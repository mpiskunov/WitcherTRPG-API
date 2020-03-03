using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.Models
{
    public class FormulaeComponent
    {
        public int ID { get; set; }
        public int FormulaeID { get; set; }
        public int SubstanceCategoryID { get; set; }
        public int Amount { get; set; }
        public Formulae Formulae { get; set; }
    }
}
