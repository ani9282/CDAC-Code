using System.Collections.Generic;
using System.Web.Http;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class EmployeeController : ApiController
    {
       static readonly IEmployeeRepository employeeRepository = new EmployeeRepository();

       //GET all employees
                                        
        //api/employee

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeeRepository.GetAll();
        }


        // GET a particular employee

        //api/employee/2
        public Employee GetEmployee(int id)
        {
            return employeeRepository.Get(id); ;

        }

        //POST (insert) an employee

        //api/employee/
        public Employee PostEmployee(Employee employee)
        {
            return employeeRepository.Add(employee);
        }

        //PUT (update) an employee

        //api/employee/{id}
        public Employee PutEmployee(int id, Employee employee)
        {
            employee.id = id;
            return employeeRepository.Update(employee);
            
        }

        //DELETE an employee

        //api/employee/{id}
        public IEnumerable<Employee> DeleteEmployee(int id)
        {
            return employeeRepository.Delete(id);           

        }
    }
}
