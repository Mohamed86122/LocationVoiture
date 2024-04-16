using LocationVoiture.Data;
using LocationVoiture.Models;
using Microsoft.EntityFrameworkCore;

namespace LocationVoiture.Repository
{
    public class VoitureRepository : IVoitureRepository
    {
        private readonly AppDbContext _context;

        public VoitureRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Voiture>> GetAllVoituresAsync()
        {
            return await _context.Voitures.ToListAsync();
        }

        public async Task<Voiture> GetVoitureByIdAsync(int voitureId)
        {
            return await _context.Voitures.FindAsync(voitureId);
        }

        public async Task AddVoitureAsync(Voiture voiture)
        {
            _context.Voitures.Add(voiture);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateVoitureAsync(Voiture voiture)
        {
            _context.Entry(voiture).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteVoitureAsync(int voitureId)
        {
            var voiture = await _context.Voitures.FindAsync(voitureId);
            if (voiture != null)
            {
                _context.Voitures.Remove(voiture);
                await _context.SaveChangesAsync();
            }
        }
    }

}
