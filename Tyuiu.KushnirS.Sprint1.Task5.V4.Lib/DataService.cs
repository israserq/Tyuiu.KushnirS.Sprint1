﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KushnirS.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            var res = time / 60 / 60;
            return res;
        }
    }
}
