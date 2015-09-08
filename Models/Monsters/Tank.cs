using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TowerDefenceMVC.Models.Monsters
{
    public class Tank: Monster
    {
        public Tank()
        {
            speed = 1;
            helth = 200;
            name = "Tank";
        }
    }
}