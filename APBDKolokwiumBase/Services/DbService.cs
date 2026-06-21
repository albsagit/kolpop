using APBDKolokwiumBase.Data;

namespace APBDKolokwiumBase.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;

    public DbService(DatabaseContext context)
    {
        _context = context;
    }
}
