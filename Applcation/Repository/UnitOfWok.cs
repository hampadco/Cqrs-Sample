

public class UnitOfWok : IUnitOfWok
{

    //context
    private readonly Context _context;

    public UnitOfWok(Context context)
    {
        _context = context;
    }


    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}