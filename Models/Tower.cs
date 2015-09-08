using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TowerDefenceMVC.Models
{
    public class Tower
    {
        public string Name { set; get; }
        public int DamagePerSecond { set; get; }
        public double Radius { set; get; }
    }
}