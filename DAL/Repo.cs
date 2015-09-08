using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TowerDefenceMVC.Models;


namespace TowerDefenceMVC.DAL
{
    public class Repo
    {
        static List<Game> games = new List<Game>();

        public void Add(Game g)
        {
            games.Add(g);
        }

        public Game FindByAttackerName(string s)
        {
            foreach (Game i in games)
                if (i.AttackerName == s)
                    return i;
            throw new Exception();
        }

        public Game FindByDeffenderName(string s)
        {
            foreach (Game i in games)
                if (i.DeffenderName == s)
                    return i;
            throw new Exception();
        }

        public bool IsClear()
        {
            if (games.Count == 0)
                return true;
            return false;
        }


        public void AddToGameWithDefender(string attakerName)
        {
            foreach (Game i in games)
                if (i.AttackerName == null && i.DeffenderName != null)
                {
                    i.AttackerName = attakerName;
                    return;
                }
            games.Add(new Game() { AttackerName = attakerName });
        }

        public void AddToGameWithAttacker(string deffenderName)
        {
            foreach (Game i in games)
                if (i.AttackerName != null && i.DeffenderName == null)
                {
                    i.DeffenderName = deffenderName;
                    return;
                }
            games.Add(new Game() { DeffenderName = deffenderName });
        }
    }
}