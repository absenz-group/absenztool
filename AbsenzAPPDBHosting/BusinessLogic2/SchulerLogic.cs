using AbsenzAPPDBHosting.Data;
using AbsenzAPPDBHosting.Models;
using AbsenzAPPDBHosting.Models.SchulerAbsenzUbersicht;
using static System.Net.Mime.MediaTypeNames;

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


        public SchulerUbersicht GetSchulerdata()
        {

            SchulerUbersicht schulerUbersicht = new SchulerUbersicht();

            try
            {

                Schueler schuler1 = new Schueler();
                schuler1 = _context.Schueler.FirstOrDefault(s => s.Id == _schulerId);


                schulerUbersicht = new SchulerUbersicht()
                {
                    Id = schuler1.Id,
                    Name = schuler1.Name
                };

                //_context.Absenzen.Where(s => s.Schueler.Id == _schulerId);

                schulerUbersicht.UnentschuldigtCount = 0;


            }
            catch (Exception ex)
            {
            }

            return schulerUbersicht;
        }
    }
}
