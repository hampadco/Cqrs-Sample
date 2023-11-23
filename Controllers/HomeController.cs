

using Microsoft.AspNetCore.Mvc;
using MediatR;

[Route("[Action]")]
[ApiController]

public class HomeController: ControllerBase
{
   
   //Mediator
    private readonly IMediator _mediator;

 
 

    public HomeController(IMediator mediator, IStudent student)
    {
        _mediator = mediator;
    }
    

    
    
    [HttpGet]
    public IActionResult GetAllStudent()
    {
        //use mediator
        var result = _mediator.Send(new GetAllStudentQuery());
        return Ok(result.Result.Students);
    }

    [HttpPost]
    public IActionResult AddStudent(TblStudent student)
    {
        //_student.AddStudent(student);
        //use mediator
        var result = _mediator.Send(new SaveStudentCommand()
        {
            Name = student.Name,
            Address = student.Address
        });
        return Ok();
    }

   


    
}