using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TowerDefenceMVC.Models.Monsters;
using TowerDefenceMVC.Models.Towers;

namespace TowerDefenceMVC.Models
{
    public class Game
    {
        public string AttackerName { set; get; }

        public string DeffenderName { set; get; }
        
        public int CurrentWave { set; get; }
        
        public Field field { set; get; }

        public int Id { set; get; }

        //id, присваиваемые игрокам при подключении в игру (для SignalR)
        public string ConnectionDefId { set; get; }

        public string ConnectionAtId { set; get; }
    }
}