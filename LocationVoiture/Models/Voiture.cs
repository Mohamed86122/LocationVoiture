namespace LocationVoiture.Models
{
    public class Voiture
    {
        public int VoitureId { get; set; }

        public string Matricule { get; set; }

        public int Nbr_portes { get; set; }

        public int Nbr_places { get; set; }

        public string Photo1 { get; set; }

        public string Couleur { get; set;}

        public Marque Marque { get; set; }

        public int MarqueId {  get; set; }

        public ICollection<Assurance> Assurances { get; set; }

        public ICollection<Location> Locations { get; set; }


    }

}
