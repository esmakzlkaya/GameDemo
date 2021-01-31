using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class GamerManager : IGamerService
    {
        public void DeleteProfile(Gamer gamer)
        {
            Console.WriteLine("Gamer "+gamer.FirstName+" has deleted.");
        }

        public void SignUp(Gamer gamer)
        {
            Console.WriteLine("Gamer " + gamer.FirstName + " has signed up.");
        }

        public void UpdateProfile(Gamer gamer)
        {
            Console.WriteLine("Gamer " + gamer.FirstName + " has updated.");
        }
    }
}
