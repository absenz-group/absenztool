using System.ComponentModel.DataAnnotations;

namespace AbsenzAPPDBHosting.Models
{
    public class Schueler
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int KlasseId { get; set; }
        
        public Klassen Klassen { get; set; }

        public ICollection<Absenzen> Absenzen { get; set; }
        public ICollection<CrossSchuelerEltern> CrossSchuelerEltern { get; set; }
    }
}
