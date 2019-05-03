using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Model
{
    /// <summary>
    /// Служащий организации
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Уникальный номер сотрудника
        /// </summary>
        public int Id;

        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        public string LastName;

        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string FirstName;
    }
}
