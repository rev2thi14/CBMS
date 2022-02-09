using CityBusManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusManagement.DAL.Repository
{
    public interface IEmployeeRepository
    {
        public void AddEmployeeDetails(Employee employeedetails);
        public void UpdateEmployeeDetails(Employee employeedetails);
        public void DeleteEmployeeDetails(int empNo);
        public Employee GetEmployeeNo(int empNo);
        IEnumerable<Employee> GetEmployeeDetails();
    }
}
