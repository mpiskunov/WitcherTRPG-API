﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPG_API.ModelsHelper;
using WitcherTRPGWebApplication.Models;

namespace WitcherTRPG_API.Models
{
    public class MonsterSkill : WitcherObject
    {
        public int ID { get; set; }
        public int MonsterID { get; set; }
        public int SkillID { get; set; }
        public int Value { get; set; }
        public Monster Monster { get; set; }
        public Skill Skill { get; set; }
    }
}
