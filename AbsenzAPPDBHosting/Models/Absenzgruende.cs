using System.ComponentModel.DataAnnotations;

namespace AbsenzAPPDBHosting.Models
{
    public class Absenzgruende
    {
        [Key]
        public int Id { get; set; }

        public string Grund { get; set; }
    }
}
