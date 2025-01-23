using AbsenzAPPDBHosting.Data;
using AbsenzAPPDBHosting.Models;
using Microsoft.EntityFrameworkCore;

namespace AbsenzAPPDBHosting.BusinessLogic2;

public class AdminLogic
{
    private readonly ApplicationDbContext _context;

    public AdminLogic(ApplicationDbContext context)
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

    public List<Schueler> FilterSchueler(string filter)
    {
        List<Schueler> filteredList = new List<Schueler>();
        try
        {
            if (!string.IsNullOrWhiteSpace(filter))
            {
                filteredList = _context.Schueler
                    .Where(s => s.Name.Contains(filter) || s.Klassen.Klasse.Contains(filter)) // Assuming Klasse is a navigation property
                    .ToList();
            }
            else
            {
                filteredList = _context.Schueler.ToList(); // Return the full list if no filter is applied
            }
        }
        catch (Exception ex)
        {
            // Log or handle the exception as needed
        }
        return filteredList;
    }
}