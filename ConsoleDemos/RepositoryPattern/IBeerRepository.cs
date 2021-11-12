using System.Collections;
using System.Collections.Generic;
using ConsoleDemos.RepositoryPattern.Model;

namespace ConsoleDemos.RepositoryPattern
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> Get();
        Beer Get(int id);
        void Add(Beer data);
        void Delete(int id);
        void Update(Beer data);
        void Save();
    }
}