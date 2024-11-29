using System.ComponentModel.DataAnnotations;

namespace AbsenzAPPDBHosting.Models
{
    public class Klassen
    {
        [Key]
        public int Id { get; set; }
        public string Klasse { get; set; }
    }
}
