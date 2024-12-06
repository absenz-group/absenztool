using System.ComponentModel.DataAnnotations;

namespace AbsenzAPPDBHosting.Models
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        public string Modul {  get; set; }

        public ICollection<Absenzen> Absenzen { get; set; }
    }
}
