using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Haven.Models;
using HR_Haven.Services;

public class EmployeeDataService : IDataService
{
    private List<Employee> _employees = new List<Employee>();

    public async Task<List<Employee>> GetEmployeesAsync()
    {
        return await Task.FromResult(_employees);
    }

    public async Task<Employee> GetEmployeeAsync(int id)
    {
        return await Task.FromResult(_employees.FirstOrDefault(e => e.Id == id));
    }

    public async Task<bool> AddEmployeeAsync(Employee employee)
    {
        _employees.Add(employee);
        return await Task.FromResult(true);
    }

    public async Task<bool> UpdateEmployeeAsync(Employee employee)
    {
        var existingEmployee = _employees.FirstOrDefault(e => e.Id == employee.Id);
        if (existingEmployee != null)
        {
            _employees.Remove(existingEmployee);
            _employees.Add(employee);
            return await Task.FromResult(true);
        }

        return await Task.FromResult(false);
    }

    public async Task<bool> DeleteEmployeeAsync(int id)
    {
        var employee = _employees.FirstOrDefault(e => e.Id == id);
        if (employee != null)
        {
            _employees.Remove(employee);
            return await Task.FromResult(true);
        }

        return await Task.FromResult(false);
    }
    public async Task<Employee> AddEmployeeAsync(Employee employee)
    {
        // Add code to create a new employee in the database
    }

    public async Task<Employee> UpdateEmployeeAsync(Employee employee)
    {
        // Add code to update an existing employee in the database
    }

    public async Task DeleteEmployeeAsync(int id)
    {
        // Add code to delete an employee from the database
    }

}
