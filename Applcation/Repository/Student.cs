

public class Student : IStudent
{
    //Context
    private readonly Context _context;

    //ILog
    private readonly ILog _log;

    public Student(Context context, ILog log)
    {
        _context = context;
        _log = log;
    }
    
    public bool AddStudent(TblStudent student)
    {
       //add student
            _context.tblStudents.Add(student);
           

            //add log
            _log.AddLog(new TblLog()
            {

                Message = "Add Student",
                StackTrace = "Add Student",
                CreateBy = "System",
                CreatedAt = DateTime.Now,
                UpdateAt = DateTime.Now,
                UpdateBy = "System"
                
            });

            
            return true;
    }

    public List<TblStudent> GetAllStudent()
    {
        //get all student
        return _context.tblStudents.ToList();

    }
}