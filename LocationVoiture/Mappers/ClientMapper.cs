using LocationVoiture.Models;
using LocationVoiture.ViewModel;

namespace LocationVoiture.Mappers
{
    public class ClientMapper
    {
        public Client AddClientMap(ClientVm model)
        {
            var client = new Client
            {
                Nom = model.Nom,
                Prenom = model.Prenom,
                Tel = model.Tel,
                CIN = model.CIN,

            };


            if (model.SelectedLocations != null && model.SelectedLocations.Any())
            {
                client.Locations = model.SelectedLocations
                    .Select(locationId => new Location
                    {
                        LocationId = locationId
                    })
                    .ToList();
            }

            return client;
        }
    }
}
