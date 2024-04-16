namespace LocationVoiture.Models
{
    public class Marque
    {
        public int MarqueId { get; set; }

        public string Libelle { get; set;}


        public ICollection<Voiture> Voitures { get; set; }
    }
}
