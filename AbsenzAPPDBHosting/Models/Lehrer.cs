using System.ComponentModel.DataAnnotations;

namespace AbsenzAPPDBHosting.Models
{
    public class Lehrer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Absenzen> Absenzen { get; set; }
    }
}
