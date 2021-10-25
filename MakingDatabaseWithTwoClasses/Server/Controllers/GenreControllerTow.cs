using MakingDatabaseWithTwoClasses.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakingDatabaseWithTwoClasses.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class GenreControllerTow:ControllerBase
    {
        private readonly ApplicationDBcontext context;
        public GenreControllerTow (ApplicationDBcontext context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<ActionResult<string>> Post(Class2 class2)
        {
            context.Add(class2);
            await context.SaveChangesAsync();
            return class2.ID;
        }

    }
}
