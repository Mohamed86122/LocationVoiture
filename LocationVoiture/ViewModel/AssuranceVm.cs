using LocationVoiture.Models;
using System.ComponentModel.DataAnnotations;

namespace LocationVoiture.ViewModel
{
    public class AssuranceVm
    {
        [Required]
        public string Agence { get; set; }
        [Required]
        public DateTime Date_Debut { get; set; }

        [Required]
        public DateTime Date_Fin { get; set; }
        [Required]
        public int Prix { get; set; }
        [Required]
        public int VoitureId { get; set; }
    }
}
