using System.ComponentModel.DataAnnotations;

namespace AbsenzAPPDBHosting.Models
{
    public class Absenzen
    {
        [Key]
        public int Id { get; set; }
        public Schueler Schueler { get; set; }
        public Absenzgruende Absenzgrund { get; set; }
        public Module Modul { get; set; }
        public Lehrer Lehrer { get; set; }
        public string Notiz { get; set; }
        public DateTime Datum { get; set; }
    }
}
