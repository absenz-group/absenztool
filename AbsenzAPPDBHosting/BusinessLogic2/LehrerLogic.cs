using AbsenzAPPDBHosting.Data;
using AbsenzAPPDBHosting.Models;
using AbsenzAPPDBHosting.Models.SchulerAbsenzUbersicht;

namespace AbsenzAPPDBHosting.BusinessLogic2
{
    public class LehrerLogic
    {

        private readonly ApplicationDbContext _context;

        public LehrerLogic(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Schueler> GetSchulerListe()
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

        public List<Absenzgruende> GetAbsenzgruende()
        {
            List<Absenzgruende> absenzGruendeList = new List<Absenzgruende>();

            try
            {
                absenzGruendeList = _context.Absenzgruende.ToList();
            }
            catch (Exception ex)
            {

            }

            return absenzGruendeList;
        }
    }
}
