using System;
using System.Collections.Generic;

namespace MvcApplication1.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees = new List<Employee>();
        private int _nextId = 1;

        public EmployeeRepository()
        {
            Add(new Employee { id = 1, name = "Michale Sharma", gender = "Male", age = 25, salary=10000 });
            Add(new Employee { id = 2, name = "Sunil Das", gender = "Male", age = 24, salary =5000 });
            Add(new Employee { id = 3, name = "Robin Pandey", gender = "Male", age = 35,salary =45000 });
            Add(new Employee { id = 4, name = "Mona Singh", gender = "Female", age = 27, salary=12000 });
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public Employee Get(int id)
        {
            return employees.Find(e => e.id == id);
        }

        public Employee Add(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Employee");
            }
            employee.id= _nextId++;
            employees.Add(employee);
            return employee;
        }

        public Employee Update(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("Employee");
            }
            int index = employees.FindIndex(e => e.id == employee.id);            
            employees.RemoveAt(index);
            employees.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> Delete(int id)
        {
            employees.RemoveAll(e => e.id == id);
            return employees;
        }
    }
}