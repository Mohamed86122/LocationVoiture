namespace LocationVoiture.ViewModel
{
    public class LocationVm
    {
        public DateTime Date_debut { get; set; }
        public DateTime Date_fin { get; set; }

        public Boolean Retour { get; set; }

        public int Prix_jour { get; set; }

        public int ClientId { get; set; }

        public int VoitureId { get; set; }


    }
}
