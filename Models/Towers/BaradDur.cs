using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TowerDefenceMVC.Models.Towers
{
    public class BaradDur:Tower
    {
        public BaradDur()
        {
            Name = "Barad Dur";
            DamagePerSecond = 25;
            Radius = 3;
        }
    }
}