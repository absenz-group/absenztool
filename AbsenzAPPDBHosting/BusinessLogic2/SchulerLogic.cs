using AbsenzAPPDBHosting.Data;
using AbsenzAPPDBHosting.Models;
using AbsenzAPPDBHosting.Models.SchulerAbsenzUbersicht;
using Microsoft.EntityFrameworkCore;

namespace AbsenzAPPDBHosting.BusinessLogic2
{
    public class SchulerLogic
    {
        private readonly ApplicationDbContext _context;

        int _schulerId = 30301;

        public SchulerLogic(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Schueler> GetAll()
        {
            return _context.Schueler.ToList();
        }

        public SchulerUbersicht GetData()
        {
            SchulerUbersicht schulerUbersicht = new SchulerUbersicht();


            try
            {
                // Fetch the student with related class and absences
                Schueler schuler1 = _context.Schueler
                    .Include(s => s.Klassen) // Include class data
                    .Include(s => s.Absenzen) // Include absences
                    .FirstOrDefault(s => s.Id == _schulerId);

                if (schuler1 != null)
                {
                    // Populate SchulerUbersicht properties
                    schulerUbersicht = new SchulerUbersicht()
                    {
                        Id = schuler1.Id,
                        Name = schuler1.Name,
                        Klasse = schuler1.Klassen?.Klasse, // Assuming "Klasse" contains the name of the class
                        Absenzen = schuler1.Absenzen as IEnumerator<Absenzen>, // Directly assign the collection if needed
                        EntschuldigtCount = 4,
                        UnentschuldigtCount = 8,
                    };
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or rethrow based on your needs)
            }

            return schulerUbersicht;
        }
    }
}