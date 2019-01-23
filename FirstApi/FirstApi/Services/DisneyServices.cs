using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApi.Model;

namespace FirstApi.Services
{
    public class DisneyServices : IDisneyServices
    {

        private static IGetRandomDis _getRandomdis;


        public DisneyServices(IGetRandomDis getRandomDis)
        {
            _getRandomdis = getRandomDis;
        }


        public async Task<CharacterDataWrapper> GetRandomDisBasedOnSearchCritera(Search model)
        {
            return await _getRandomdis.ReturnRandomDisBasedOnTag(model);
        }


    }
}
