using Repository_Pattern_Mvc_Card_Opration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern_Mvc_Card_Opration.Repo
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
        void Save();
    }
}
