using MakingDatabaseWithTwoClasses.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakingDatabaseWithTwoClasses.Client.repostory
{
    public interface IGenreRepostosyTow
    {
        Task CreateGenre2(Class2 class2);
    }
}
