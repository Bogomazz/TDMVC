using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TowerDefenceMVC.Models.Towers
{
    public class DarkTower: Tower
    {
        public DarkTower()
        {
            Name = "Dark Tower";
            DamagePerSecond = 50;
            Radius = 1;
        }
    }
}