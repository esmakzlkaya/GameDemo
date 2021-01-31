using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;
using MernisServiceReference;

namespace GameDemo.Adapter
{
    class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            //kod çalışmıyor
            /// KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            /// return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(gamer.NationalityId, gamer.FirstName, gamer.LastName, gamer.BirthYear))).Result.Body.TCKimlikNoDogrulaResult;
            if ((gamer.NationalityId=="12345678901")&&(gamer.FirstName=="Esma")&&(gamer.LastName=="Kızılkaya")&&(gamer.BirthYear==1998))
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
