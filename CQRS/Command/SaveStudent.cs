using MediatR;
//input
public class SaveStudentCommand: IRequest<SaveStudentResult>
{
     public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}


//output
public class SaveStudentResult
{
    //bool
    public bool IsSuccess { get; set; }
}

//Hanlder proccess
public class SaveStudentHandler: IRequestHandler<SaveStudentCommand, SaveStudentResult>
{

    //Istudent
    private readonly IStudent _student;

    //ILog
    private readonly ILog _log;

    public SaveStudentHandler(IStudent student, ILog log)
    {
        _student = student;
        _log = log;
    }
    
    
    public async Task<SaveStudentResult> Handle(SaveStudentCommand request, CancellationToken cancellationToken)
    {
        //add student
        var student = new TblStudent()
        {
            Name = request.Name,
            Address = request.Address,
            
        };
        var result = _student.AddStudent(student);
        if (result)
        {
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
        }
        return new SaveStudentResult()
        {
            IsSuccess = result
        };
       

    }
   

   
}
