using MakingDatabaseWithTwoClasses.Client.hppt;
using MakingDatabaseWithTwoClasses.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakingDatabaseWithTwoClasses.Client.repostory
{
    public class GenreRepostory : IGenreRepostory
    {
        private string url = "api/genres";
        private readonly IHttpService httpService;
        public GenreRepostory(IHttpService httpService)
        {
            this.httpService = httpService;
            
        }
        public async Task CreateGenre(Class1 class1) 
        {
            var response = await httpService.Post(url, class1);

            if (!response.Success) 
            {
                throw new ApplicationException(await response.GetBody());
            }
        
        }
    }
}
