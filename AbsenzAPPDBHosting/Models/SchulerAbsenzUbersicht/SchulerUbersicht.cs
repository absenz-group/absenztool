namespace AbsenzAPPDBHosting.Models.SchulerAbsenzUbersicht
{
    public class SchulerUbersicht
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Klasse { get; set; }
        public List<Eltern> Eltern { get; set; }

        public IEnumerator<Absenzen> Absenzen { get; set; }
        public int UnentschuldigtCount { get; set; }
        public int EntschuldigtCount { get; set; }
        public List<Module> ModuleList { get; set; }
    }
    
    public class SchulerAbsenzen
    {
        public int Id { get; set; }
    }
}
