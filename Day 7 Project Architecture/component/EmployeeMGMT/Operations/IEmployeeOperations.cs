using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMGMT.Models;
namespace EmployeeMGMT.Operations
{
     public interface IEmployeeOperation 
{
 public  Employee Add(Employee employee);
 public Task<List<Employee>> GetEmployees();
  public  Task<Employee> GetEmployeesByID(int id); 

 Task<Employee> UpdateEmployee(Employee employee, int id);
    public Employee DeleteEmployeeId(int id); 

    public List<Employee> SearchByAge(int age);

}
}