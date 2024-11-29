using System.ComponentModel.DataAnnotations;

namespace AbsenzAPPDBHosting.Models
{
    public class Absenzen
    {
        [Key]
        public int Id { get; set; }
        public string Schueler { get; set; }
        public DateTime Datum { get; set; }
        public string Absenzgrund { get; set; }
        public string Lehrer { get; set; }
        public int Modul { get; set; }
    }
}
