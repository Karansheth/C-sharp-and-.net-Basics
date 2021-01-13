using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeApi.Models
{
    public class Employee
    {
        /// <summary>
        /// Age of an Employee
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Empoyee Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of an Employee
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Role of an Employee in a company
        /// </summary>
        public string Role { get; set; }
    }
}