using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TowerDefenceMVC.Models
{
    public class Field
    {
        int width;
        int height;
        int[,] field;

        // public int[,] Field { get { return field; } } 

        public Field(int Width, int Heigth)
        {
            width = Width;
            height = Heigth;
            field = new int[Width, Heigth];
        }
    }
}