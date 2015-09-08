using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TowerDefenceMVC.Models.Monsters
{
    public class Fighter: Monster  //истребитель
    {
        public Fighter()
        {
            speed = 3;
            helth = 100;
            name = "Fighter";
        }
    }
}