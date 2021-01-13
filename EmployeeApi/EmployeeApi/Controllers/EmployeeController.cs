using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeApi.Models;

namespace EmployeeApi.Controllers
{

    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        
        /// <summary>
        /// As we are not introduced to database in the training the data is stored in static field
        /// </summary>
        List<Employee> emp = new List<Employee>()
        {
            new Employee{ Age = 21, Id = 105, Name = "Karan", Role = "Technology Intern"},
            new Employee{ Age = 30, Id = 101, Name = "Het", Role = "Senior Software Engineer"},
            new Employee{ Age = 24, Id = 102, Name = "Saiyam", Role = "Junior Software Engineer"},
            new Employee{ Age = 35, Id = 103, Name = "Keyur", Role = "Product Manager"},
            new Employee{ Age = 25, Id = 104, Name = "Dev", Role = "Lead Software Engineer"},
        };

        

        /// <summary>
        /// GetAll Method will return list of all employees in list named as "emp"
        /// </summary>
        /// <returns>List of all Employees</returns>
        [Route("Employee")]
        public List<Employee> GetAll()
        {
            return emp;
        }

        /// <summary>
        /// Get Method will return information of an employee whose id is passed by the user
        /// </summary>
        /// <param name="id">Employee id which should be passed by the user to get information about that particular employee</param>
        /// <returns>Information of one particular employee whose id matches the id passed by the user</returns>
        [Route("Employee/{id}")]
        public Employee Get(int id)
        {
            return emp.Find(x => x.Id == id);
        }

        /// <summary>
        /// To add details of new Employee
        /// </summary>
        /// <param name="e">Details of new employee entered through postman.</param>
        /// <returns>Details of all employees in the company after changes.</returns>
        [Route("Employee")]
        public List<Employee> Post([FromBody]Employee e)
        {
            emp.Add(e);
            return emp;
        }

        /// <summary>
        /// To update employee information
        /// </summary>
        /// <param name="id">Employeed id of a employee whose information is to be updated.</param>
        /// <param name="e">Changed information of existing employee.</param>
        /// <returns>Details of all employees in the company after changes.</returns>
        [Route("Employee/{id}")]
        public List<Employee> Put(int id, [FromBody]Employee e)
        {
            emp = emp.Where(x => x.Id != id).ToList();
            emp.Add(e);
            return emp;
        }

        /// <summary>
        /// To delete information of a particular employee of the company.
        /// </summary>
        /// <param name="id">Employee Id of an employee whose information is to be deleted.</param>
        /// <returns>Details of all employees in the company after changes.</returns>
        [Route("Employee/{id}")]
        public List<Employee> Delete(int id)
        {
            emp = emp.Where(x => x.Id != id).ToList();
            return emp;
        }
    }
}
