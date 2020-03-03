using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class RammingSizeModifier : Modifier
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
    }
}
