using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApi.Models
{
   public interface IRepository<T> where T:class
    {
        IQueryable<T> GetAll();
        T GetSingleRecord(int id);

        IQueryable<T> Search(string search);
        bool SaveChanges();
        bool Insert(T data);
        bool Update(T data);
        bool DeleteRecord(int id);
      

    }
}
