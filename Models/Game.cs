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

        public List<Monster> MonstersWaveOne = new List<Monster>() { new Soldier(), new Soldier(), new Soldier(), new Soldier(), new Soldier(), new Soldier() };
        List<Monster> MonstersWaveTwo = new List<Monster>() { new Soldier(), new Soldier(), new Soldier(), new Soldier(), new Tank(), new Tank(), new Fighter()};
        List<Monster> MonstersWaveThree = new List<Monster>();

        List<Tower> TowersWaveOne = new List<Tower>();
        List<Tower> TowersWaveTwo = new List<Tower>();
        List<Tower> TowersWaveThree = new List<Tower>();

        
    
    }
}