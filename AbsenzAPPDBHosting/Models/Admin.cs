using System.ComponentModel.DataAnnotations;

namespace AbsenzAPPDBHosting.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
