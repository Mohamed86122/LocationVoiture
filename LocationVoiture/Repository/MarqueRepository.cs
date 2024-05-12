using LocationVoiture.Data;
using LocationVoiture.Models;
using LocationVoiture.ViewModel;

namespace LocationVoiture.Repository
{
    public class MarqueRepository : IMarqueRepository
    {
        AppDbContext _context;
        public MarqueRepository(AppDbContext context) 
        {
            _context = context;
        }
        public async Task AddMarqueAsync(Marque marque)
        {
            _context.Marques.Add(marque);
            await _context.SaveChangesAsync();
        }

        public Task DeleteMarque(int id)
        {
            throw new NotImplementedException();
        }

        public List<Marque> GetAllMarques()
        {
            throw new NotImplementedException();
        }

        public Marque GetMarqueById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMarque(Marque marque)
        {
            throw new NotImplementedException();
        }
    }
}
