using System.ComponentModel.DataAnnotations;

namespace AbsenzAPPDBHosting.Models
{
    public class Eltern
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Handynummer { get; set; }

        public ICollection<CrossSchuelerEltern> CrossSchuelerEltern { get; set; }
    }
}
