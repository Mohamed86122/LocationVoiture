using LocationVoiture.Models;

namespace LocationVoiture.Repository
{
    public interface IMarqueRepository
    {

         Marque GetMarqueById(int id);
         List<Marque> GetAllMarques();

         Task AddMarqueAsync (Marque marque);

        Task UpdateMarque(Marque marque);

        Task DeleteMarque(int id);
    }
}
