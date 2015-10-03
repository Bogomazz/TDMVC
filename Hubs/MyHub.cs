using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using TowerDefenceMVC.DAL;

namespace TowerDefenceMVC.Hubs
{
    public class MyHub: Hub 
    {
        Repository games = new Repository();
        //Добавление пользователя и составление пар
        public void Connect(string userName, string side)
        {
            int gameId;
            //В зависимости от выбранной пользователем стороны добавление в игру
            if (side == "defense")
                gameId = games.AddToGameWithAttacker(userName);
            else if (side == "attack")
                gameId = games.AddToGameWithDefender(userName);
            else
                throw new Exception();

            if (games.IsFull(gameId))
            {
                //метод на клиенте запуска первой волны для 2-х пользователей из этой игры
            }

            else
            {
                //метод на клиенте отображающий ожидание
            }

        }
    }
}