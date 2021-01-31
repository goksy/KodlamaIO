using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;
namespace GameProject.Adapter
{
    class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody
                (Convert.ToInt64(player.NationalityId), player.FirstName, player.LastName, player.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
