namespace LocationVoiture.ViewModel
{
    public class VoitureVm
    {
        public string Matricule { get; set; }

        public int Nbr_portes { get; set; }

        public int Nbr_places { get; set; }

        public string Photo1 { get; set; }

        public string Couleur { get; set; }

        public int MarqueId { get; set; }

        public List<int> SelectAssurance { get; set; }

        public List<int> SelectLocation { get; set; }
    }
}
