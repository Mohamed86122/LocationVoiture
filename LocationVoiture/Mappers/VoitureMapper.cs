using LocationVoiture.Models;
using LocationVoiture.ViewModel;

namespace LocationVoiture.Mappers
{
    public class VoitureMapper
    {
        public Voiture AddVoitureMap ( VoitureVm model ) 
        {
            var voiture = new Voiture()
            {
                Matricule = model.Matricule,
                Nbr_portes = model.Nbr_portes,
                Nbr_places = model.Nbr_places,
                Photo1 = model.Photo1,
                Couleur = model.Couleur,
                MarqueId = model.MarqueId,

                

            };

            if (model.SelectAssurance != null && model.SelectAssurance.Any())
            {
                voiture.Assurances = model.SelectAssurance
                    .Select(Assuranceid => new Assurance
                    {
                        AssuranceId = Assuranceid
                    })
                    .ToList();
            }
            if (model.SelectLocation != null && model.SelectLocation.Any())
            {
                voiture.Locations = model.SelectLocation
                    .Select(locationId => new Location
                    {
                        LocationId = locationId
                    })
                    .ToList();
            }

            return voiture;
        }
    }
}
