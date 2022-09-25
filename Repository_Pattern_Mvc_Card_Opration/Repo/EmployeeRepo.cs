using Repository_Pattern_Mvc_Card_Opration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository_Pattern_Mvc_Card_Opration.Repo
{
    public class EmployeeRepo : IEmployee
    {
        private Mvc_RepositoryPattern22Entities _context;

        public EmployeeRepo(Mvc_RepositoryPattern22Entities context)
        {
            _context = context;   
        }

        public void Delete(Employee employee)
        {
            _context.Entry(employee).State = System.Data.Entity.EntityState.Deleted;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Where(x=>x.id==id).FirstOrDefault();    
        }

        public void Insert(Employee employee)
        {
            _context.Employees.Add(employee);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _context.Entry(employee).State = System.Data.Entity.EntityState.Modified;
        }
    }
}