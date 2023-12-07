using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.System.DAL;

public class GenericReop<T> : IGenericRepo<T> where T : class
{
    private readonly VezeetaContext _context;

    public GenericReop(VezeetaContext context)
    {
        _context = context;
    }

    public void Add(T obj)
    {
        _context.Set<T>().Add(obj);
    }

    //our generic methods
    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().AsNoTracking();
    }

    public void Remove(T obj)
    {
        throw new NotImplementedException();
    }
}
