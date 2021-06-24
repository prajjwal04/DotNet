using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prac2.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {

        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id=1,name="prajjwal",email="prajjwal@gmail.com"},
                new Employee(){ Id=2,name="palak",email="palak@gmail.com"},
                new Employee(){ Id=3,name="anita",email="anita@gmail.com"}

            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}