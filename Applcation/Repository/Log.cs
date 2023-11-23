
public class Log : ILog
{
    //Context
    private readonly Context _context;

    //IUnitOfWok
    private readonly IUnitOfWok _unitOfWok;

    public Log(Context context, IUnitOfWok unitOfWok)
    {
        _context = context;
        _unitOfWok = unitOfWok;
    }
   
    public bool AddLog(TblLog log)
    {
        //add log
        _context.tblLogs.Add(log);

        //save change
        _unitOfWok.SaveChanges();
      
        return true;
    }

    public List<TblLog> GetAllLog()
    {
        //get all log
        return _context.tblLogs.ToList();
    }
}