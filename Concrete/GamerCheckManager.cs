using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if ((gamer.NationalityId == "12345678901") && (gamer.FirstName == "Esma") && (gamer.LastName == "Kızılkaya") && (gamer.BirthYear == 1998))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
