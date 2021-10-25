using MakingDatabaseWithTwoClasses.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakingDatabaseWithTwoClasses.Client.repostory
{
    public interface IGenreRepostory
    {
        Task CreateGenre(Class1 class1);
    }
}
