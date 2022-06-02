﻿using BuisnessLogicLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Services
{
    public interface IResources
    {
        Task<Employee> AddEmployeeAsync(Employee item);
        void RemoveEmployee(int id);
        Employee GetEmployee(int id);
        Task<List<string>> GetAllTitlesAsync();
        Employee UpdateEmployee(Employee item);
        Task<ICollection<Employee>> GetEmployees(string title);
    }
}