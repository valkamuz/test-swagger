using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApi.Model;

namespace TestApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// Получить перечень всех служащих
        /// </summary>
        /// <returns>Список служащих</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return new []
            { 
                new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван" },
                new Employee { Id = 2, LastName = "Петров", FirstName = "Петр" }
            };
        }


        /// <summary>
        /// Получить информацию о служащем по уникальному номеру
        /// </summary>
        /// <remarks>
        /// Проверить работу сервиса можно на пользователе с уник. номером = 1.
        /// 
        /// Для остальных случаев этот тестовый сервер будет возвращать результат NotFound (код = 404).
        /// </remarks>
        /// <returns>Служащий</returns>
        /// <response code="200">В случае, если сотрудник найден! В этом случае в теле будет информация о найденном сотруднике.</response>  
        /// <response code="404">В случае, если сотрудник с указанным уникальным номером не найден!</response>  
        [HttpGet("{idEmployee}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200)]
        public ActionResult<Employee> GetById(int idEmployee)
        { 
            if (idEmployee != 1)
                return NotFound();

            Employee employee = new Employee
            { 
                Id          = 1,
                LastName    = "Иванов",
                FirstName   = "Иван"
            };

            return employee;
        }

    }
}
