using LocationVoiture.Models;

namespace LocationVoiture.Repository
{
    public interface IVoitureRepository
    {
        Task<IEnumerable<Voiture>> GetAllVoituresAsync();
        Task<Voiture> GetVoitureByIdAsync(int voitureId);
        Task AddVoitureAsync(Voiture voiture);
        Task UpdateVoitureAsync(Voiture voiture);
        Task DeleteVoitureAsync(int voitureId);
    }
}
