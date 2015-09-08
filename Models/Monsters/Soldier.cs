using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TowerDefenceMVC.Models.Monsters
{
    public class Soldier: Monster
    {
        public Soldier()
        {
            speed = 2;
            helth = 200;
            name = "Soldier";
        }
    }
}