using MediatR;

//use mediatr to get all student
public class GetAllStudentQuery: IRequest<GetAllStudentResult>
{
    
}

//output
public class GetAllStudentResult
{
    public List<TblStudent> Students { get; set; }
}

//handler
public class GetAllStudentHandler: IRequestHandler<GetAllStudentQuery, GetAllStudentResult>
{
    //Istudent
    private readonly IStudent _student;

    public GetAllStudentHandler(IStudent student)
    {
        _student = student;
    }
    
    public async Task<GetAllStudentResult> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
    {
        return new GetAllStudentResult()
        {
            Students = _student.GetAllStudent()
        };
    }
}
