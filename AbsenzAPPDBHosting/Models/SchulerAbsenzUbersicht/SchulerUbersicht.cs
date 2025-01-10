namespace AbsenzAPPDBHosting.Models.SchulerAbsenzUbersicht
{
    public class SchulerUbersicht
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Klasse { get; set; }
        public List<Eltern> Eltern { get; set; }

        public List<Absenzen> Absenzen { get; set; }
        public int UnentschuldigtCount { get; set; }
        public int EntschuldigtCount { get; set; }
    }
}
