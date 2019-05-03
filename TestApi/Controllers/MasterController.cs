using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApi.Model;


namespace TestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        /// <summary>
        /// Получить перечень всех мастеров
        /// </summary>
        /// <returns>Список служащих</returns>
        /// <response code="200">В любом случае ответ будет успешен (нет обращений к базе данных)!</response>  
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<Master>> Get()
        {
            return new []
            { 
                new Master { Id = 1, Dan = "Первый дан" },
                new Master { Id = 2, Dan = "Второй дан" },
            };
        }

    }
}
