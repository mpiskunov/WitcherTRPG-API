﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.Models;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPG_API.ViewModels
{
    public class ArmorViewModel
    {
        public Armor Armor { get; set; }
        public IEnumerable<ArmorEffect> ArmorEffects { get; set; }
        public IEnumerable<ArmorCover> ArmorCovers { get; set; }
        public CraftingDiagram CraftingDiagram { get; set; }
        public IEnumerable<CraftingDiagramComponent> CraftingDiagramComponents { get; set; }
    }
}
