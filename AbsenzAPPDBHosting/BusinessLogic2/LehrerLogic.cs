using AbsenzAPPDBHosting.Data;
using AbsenzAPPDBHosting.Models;

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

        public bool SaveAbwesenheit(DateTime datum, string lektionsBeschreibung, string grundBeschreibung)
        {
            try
            {
                // Fetch or create Absenzgrund based on description
                var absenzgrund = _context.Absenzgruende
                                      .FirstOrDefault(g => g.Grund == grundBeschreibung) 
                                  ?? new Absenzgruende { Grund = grundBeschreibung };

                // Fetch Lektion based on description or create if necessary
                var lektion = _context.Module
                                  .FirstOrDefault(m => m.Modul == lektionsBeschreibung)
                              ?? new Module { Modul = lektionsBeschreibung };

                // Fetch the Lehrer from the context, assuming it's linked to the current user (example)
                var lehrer = _context.Lehrer.FirstOrDefault(); // Adjust logic to fetch the appropriate teacher

                if (lehrer == null)
                {
                    return false; // Lehrer is required
                }

                // Create a new Absenzen entry
                var absenzen = new Absenzen
                {
                    Datum = datum,
                    Absenzgrund = absenzgrund,
                    Modul = lektion,
                    Lehrer = lehrer,
                    Notiz = grundBeschreibung
                };

                // Add the new Absenzen to the context
                _context.Absenzen.Add(absenzen);

                // Save changes to the database
                _context.SaveChanges();

                return true; // Indicate success
            }
            catch (Exception ex)
            {
                // Handle or log the exception as needed
                return false; // Indicate failure
            }
        }
    }
}