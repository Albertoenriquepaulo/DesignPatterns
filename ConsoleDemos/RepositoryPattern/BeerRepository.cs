using System.Collections.Generic;
using System.Linq;
using ConsoleDemos.RepositoryPattern.Model;
using Microsoft.EntityFrameworkCore;

namespace ConsoleDemos.RepositoryPattern
{
    public class BeerRepository :IBeerRepository
    {
        private readonly DesignPatternsContext _context;

        public BeerRepository(DesignPatternsContext context)
        {
            _context = context;
        }

        public IEnumerable<Beer> Get() => _context.Beers.ToList();
        public Beer Get(int id) => _context.Beers.Find(id);

        public void Add(Beer data) => _context.Beers.Add(data);

        public void Delete(int id) => _context.Beers.Remove(Get(id));

        public void Update(Beer data) => _context.Entry(data).State = EntityState.Modified;

        public void Save() => _context.SaveChanges();
    }
}