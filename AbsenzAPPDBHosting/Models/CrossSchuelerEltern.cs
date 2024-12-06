using System.ComponentModel.DataAnnotations;

namespace AbsenzAPPDBHosting.Models
{
    public class CrossSchuelerEltern
    {
        [Key]
        public int Id { get; set; }
        public Schueler ID_Schueler { get; set; }
        public Eltern ID_Eltern { get; set; }
    }
}
