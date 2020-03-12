﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Race
    {
        public int ID { get; set; }
        [Required]
        public string Type { get; set; }
        public string Description { get; set; }
        public RaceType RaceType { get; set; }
    }
}
