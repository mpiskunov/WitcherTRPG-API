﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WitcherTRPGWebApplication.ModelsHelper;

namespace WitcherTRPGWebApplication.Models
{
    public class Skill
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PointsPerLevel { get; set; }
        public SkillCategory SkillCategory { get; set; }
        public int StatisticID { get; set; }
        public Statistic Statistic { get; set; }
    }
}
