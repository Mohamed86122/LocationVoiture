namespace LocationVoiture.Models
{
    public class Client
    {

        public int ClientId { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string Tel { get; set; }

        public string CIN { get; set; }

        public ICollection<Location> Locations { get; set;}
    }
}
