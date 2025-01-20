using AbsenzAPPDBHosting.Data;
using AbsenzAPPDBHosting.Models;

namespace AbsenzAPPDBHosting.BusinessLogic2
{
    public class SchulerLogic
    {
        private readonly ApplicationDbContext _context;
        int _schulerId = 999;

        public SchulerLogic(ApplicationDbContext context)
        {
            _context = context;
        }


        public List<Schueler> GetSchulerdata()
        {
            List<Schueler> schulerliste = new List<Schueler>();
            try
            {
                schulerliste = _context.Schueler.ToList();
            }
            catch (Exception ex)
            {
            }
            return schulerliste;
        }
    }
}
