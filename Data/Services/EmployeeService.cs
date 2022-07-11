using Blazor_CRUD.Data.Context;
using Blazor_CRUD.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_CRUD.Data.Services
{
    public class EmployeeService
    {
        // Property
        private readonly AppDBContext _context;

        // Constructor
        public EmployeeService(AppDBContext context)
        {
            _context = context;
        }

        // Get List of Employees
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }
        // Create  Employees
        public async Task<bool> CreateAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
            return true;
        }
       // Get Employee by Id
       public async Task<Employee> GetByIdAsync(int id)
        {
            Employee employee = await _context.Employees.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return employee;
        }
        // Update Employees
        public async Task<bool> UpdateAsync(Employee employee)
        {           
           _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
            return true;
        }
        // Delete Employees
        public async Task<bool> DeleteAsync(Employee employee)
        {
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return true;
        }
    }
    
}