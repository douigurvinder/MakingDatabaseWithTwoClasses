using MakingDatabaseWithTwoClasses.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakingDatabaseWithTwoClasses.Server.Controllers
{

    [ApiController]
    [Route ("api/[controller]")]

    public class GenreController : ControllerBase
    {
        private readonly ApplicationDBcontext context;
        public GenreController(ApplicationDBcontext context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<ActionResult<string>> Post(Class1 class1) 
        {
            context.Add(class1);
            await context.SaveChangesAsync();
            return class1.ID;
        }

    }                                                                                                                                                                                  
}
