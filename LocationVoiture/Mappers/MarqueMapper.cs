using LocationVoiture.Models;
using LocationVoiture.ViewModel;

namespace LocationVoiture.Mappers
{
    public class MarqueMapper
    {
        public Marque AddmarqueMap (MarqueVm model)
        {
            var marque = new Marque()
            {
                Libelle = model.Libelle,
            };
            if (model.SelectVoitures != null && model.SelectVoitures.Any())
            {
                marque.Voitures = model.SelectVoitures
                    .Select(voitureId => new Voiture
                    {
                        VoitureId = voitureId
                    })
                    .ToList();
            }
            return marque;
        }
    }
}
