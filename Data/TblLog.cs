using System.ComponentModel.DataAnnotations;

public class TblLog
{

    [Key]
    public Guid Id { get; set; }

    public string Message { get; set; }

    public string StackTrace { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreateBy { get; set; }

    public DateTime UpdateAt { get; set; }

    public string UpdateBy { get; set; }




    

}