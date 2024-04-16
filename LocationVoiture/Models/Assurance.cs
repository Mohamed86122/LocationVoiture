namespace LocationVoiture.Models
{
    public class Assurance
    {
        public int AssuranceId { get; set; }

        public string Agence { get; set; }

        public DateTime Date_Debut { get; set; }
        public DateTime Date_Fin { get; set; }

        public int Prix { get; set; }

        public Voiture Voiture { get; set; }

        public int VoitureId { get; set; }

    }
}
