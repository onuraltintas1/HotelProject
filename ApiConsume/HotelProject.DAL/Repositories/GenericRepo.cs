using HotelProject.DAL.Abstract;
using HotelProject.DAL.Concrete;

namespace HotelProject.DAL.Repositories;

public class GenericRepo<T> : IGenericRepo<T> where T : class
{
    private readonly DataContext _context;

    public GenericRepo(DataContext context)
    {
        _context = context;
    }

    public void Insert(T t)
    {
        _context.Add(t);
        _context.SaveChanges();
    }

    public void Delete(T t)
    {
        _context.Remove(t);
        _context.SaveChanges();

    }

    public void Update(T t)
    {
        _context.Update(t);
        _context.SaveChanges();

    }

    public List<T> GetList()
    {
        return _context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }
}