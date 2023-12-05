

using App1.Data;
using Microsoft.EntityFrameworkCore;

namespace App1.Repositories
{
    public interface IIncomeRepository
    {
        Task<IEnumerable<Income>> GetAll();
        Task<Income> GetById(int id);
        Task AddIncome(Income income);
        Task UpdateIncome(Income income);
        Task DeleteIncome(int id);
    }
    public class IncomeRepository : IIncomeRepository
    {

        private readonly App1Context _context;

        public IncomeRepository(App1Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Income>> GetAll()
        {
            return await _context.Income.ToListAsync();
        }

        public async Task<Income> GetById(int id)
        {
            return await _context.Income.FindAsync(id);
        }

        public async Task AddIncome(Income income)
        {
            _context.Income.Add(income);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateIncome(Income income)
        {
            _context.Entry(income).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteIncome(int id)
        {
            var income = await _context.Income.FindAsync(id);

            if (income != null) {

                _context.Income.Remove(income);
            await _context.SaveChangesAsync();
            }
        }


    }
}
