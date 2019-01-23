using FirstApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Services
{
    public interface IGetRandomDis
    {
        Task<CharacterDataWrapper> ReturnRandomDisBasedOnTag(Search model);
    }
}
