using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class GamesManager : IGameService
    {
        public void Add(Games games)
        {
            Console.WriteLine(games.Name + " eklendi");
        }

        public void Delete(Games games)
        {
            Console.WriteLine(games.Name + " silindi");
        }
    }
}
