﻿using System.ComponentModel.DataAnnotations;

namespace AbsenzAPPDBHosting.Models
{
    public class Schueler
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Klasse { get; set; }
        public int Eltern { get; set; }

        public ICollection<Absenzen> Absenzen { get; set; }
        public ICollection<CrossSchuelerEltern> CrossSchuelerEltern { get; set; }
    }
}
