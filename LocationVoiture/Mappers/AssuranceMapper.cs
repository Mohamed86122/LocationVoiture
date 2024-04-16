using LocationVoiture.Models;
using LocationVoiture.ViewModel;

namespace LocationVoiture.Mappers
{
    public class AssuranceMapper
    {

        public Assurance AssuranceAddMap (AssuranceVm model )
        {
            return new Assurance
            {
                Agence = model.Agence,
                Date_Debut = model.Date_Debut,
                Date_Fin = model.Date_Fin,
                Prix = model.Prix,
                VoitureId = model.VoitureId,
            
            };
        }
    }
}
