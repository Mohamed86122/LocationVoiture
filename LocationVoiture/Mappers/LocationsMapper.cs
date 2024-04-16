using LocationVoiture.Models;
using LocationVoiture.ViewModel;

namespace LocationVoiture.Mappers
{
    public class LocationsMapper
    {
        public Location AddLocationMap (LocationVm model)
        {
            var location = new Location()
            {
                Date_debut = model.Date_debut,
                Date_fin = model.Date_fin,
                Retour = model.Retour,
                Prix_jour = model.Prix_jour,
                ClientId = model.ClientId,
                VoitureId = model.VoitureId,
            };

            return location;
        }
    }
}
