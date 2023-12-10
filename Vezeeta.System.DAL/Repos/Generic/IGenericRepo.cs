using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public interface IGenericRepo<T> where T : class
{
    IEnumerable<T> GetAll();
    void Add(T obj);
    void Remove(T obj);
    T GetById(Guid Id);
}
