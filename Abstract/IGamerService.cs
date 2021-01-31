using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo
{
    interface IGamerService
    {
        void SignUp(Gamer gamer);
        void UpdateProfile(Gamer gamer);
        void DeleteProfile(Gamer gamer);
    }
}
