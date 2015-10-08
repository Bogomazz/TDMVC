using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TowerDefenceMVC.Models;
using System.Data.SqlClient;
using System.Data;


namespace TowerDefenceMVC.DAL
{
    public class Repository
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public void Add(Games g)
        {
            db.Games.InsertOnSubmit(g);
            db.SubmitChanges();
        }

        public bool IsClear()
        {
            //Получение списка активных игр
            IEnumerable<Games> gameList = from games in db.Games
                                          where games.Active == true
                                          select games;
            
            //Проверка количества доступных игр
            int count = 0;
            foreach (var game in gameList)
            {
                count++;
            }
            if (count > 0)
                return true;
            return false;
        }

        //Методы возвращают id игры, в которую был добавлен пользователь
        public int AddToGameWithDefender(string attakerName)
        {
            //Получение списка активных игр
            IEnumerable<Games> gameList = from games in db.Games
                                          where games.Active == true
                                          select games;


            foreach (var game in gameList)
            {
                if (game.AttackerName == null)
                {
                    game.AttackerName = attakerName;
                    db.SubmitChanges();
                    return game.Id;
                }
            }
            

            //Заменить на собственное исключение отсутствия игры без атакующего
            throw new Exception();
        }

        public int AddToGameWithAttacker(string deffenderName)
        {
            //Получение списка активных игр
            IEnumerable<Games> gameList = from games in db.Games
                                          where games.Active == true
                                          select games;


            foreach (var game in gameList)
            {
                if (game.DefenderName == null)
                {
                    game.DefenderName = deffenderName;
                    db.SubmitChanges();
                    return game.Id;
                }
            }
            

            //Заменить на собственное исключение отсутствия игры без атакующего
            throw new Exception();
        }

        //Проверяет полон ли набор игроков в игре с заданым id
        public bool IsFull(int id)
        {
            //Получение списка активных игр
            IEnumerable<Games> gameList = from games in db.Games
                                          where games.Active == true
                                          select games;

            foreach (var game in gameList)
            {
                if (game.DefenderName != null && game.AttackerName != null)
                    return true;
            }
            return false;
        }


        //---------------------------------------------------------------------------------
        //
        //На будущее, для возможности выбирать противника

        //public Game FindByAttackerName(string s)
        //{
        //    SqlConnection connection = new SqlConnection(connectionStr);
        //    string commandString = "SELECT * FROM Games WHERE AttackerName = " + s;

        //    SqlCommand command = new SqlCommand(commandString, connection);
        //    connection.Open();

        //    Game result = new Game();

        //    using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
        //    {
        //        while (reader.Read())
        //        {
        //            result = new Game
        //            {
        //                DeffenderName = s,
        //                AttackerName = (string)reader["AttackerName"],
        //                CurrentWave = (int)reader["CurrentWave"]
        //            };
        //        }
        //    }

        //    return result;
        //}


        //public Game FindByDeffenderName(string s)
        //{
        //    foreach (Game i in games)
        //        if (i.DeffenderName == s)
        //            return i;
        //    throw new Exception();
        //}

    }
}