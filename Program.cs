using System;
using GameDemo.Entities;
using GameDemo.Concrete;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() { Id = 1, FirstName= "Esma",LastName= "Kızılkaya", NationalityId= "12345678901" ,BirthYear=1998};
            Games games = new Games() { Id=1,Name="Football Manager 2021",Price=199.20};
            Campaign campaign = new Campaign() { Id=1,Name="%20 İndirim"};
            int numberof = 2;
            Order order = new Order() { Id=1,GamerId=gamer.Id,GameId=games.Id,DateOfOrder=DateTime.Today,NumberOf=numberof,OrderPrice=games.Price*numberof};
            GamerManager gamerManager = new GamerManager();
            GamesManager gamesManager = new GamesManager();
            GamerCheckManager gamerCheckManager = new GamerCheckManager();
            CampaignManager campaignManager = new CampaignManager();
            OrderManager orderManager = new OrderManager();

            //oyuncu işlemleri
            gamerManager.SignUp(gamer);
            gamerManager.UpdateProfile(gamer);
            gamerManager.DeleteProfile(gamer);

            //oyun işlemleri
            gamesManager.Add(games);
            gamesManager.Delete(games);

            //kampanya işlemleri
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            //sipariş işlemleri
            orderManager.Order(order);
        }
    }
}
