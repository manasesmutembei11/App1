using App1.Data;
using Microsoft.EntityFrameworkCore;

namespace App1.Repositories
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetAll();
        Task<Person> GetById(int id);
        Task AddPerson(Person person);
        Task UpdatePerson(Person person);
        Task DeletePerson(int id);
    }

    public class PersonRepository : IPersonRepository
    {
        private readonly App1Context _context;

        public PersonRepository(App1Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _context.Person.ToListAsync();
        }

        public async Task<Person> GetById(int id)
        {
            return await _context.Person.FindAsync(id);
        }

        public async Task AddPerson(Person person)
        {
            _context.Person.Add(person);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePerson(Person person)
        {
            _context.Entry(person).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeletePerson(int id)
        {
            var person = await _context.Person.FindAsync(id);

            if (person != null)
            {
                _context.Person.Remove(person);
                await _context.SaveChangesAsync();
            }
        }
    }
}

