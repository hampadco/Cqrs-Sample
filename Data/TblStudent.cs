using System.ComponentModel.DataAnnotations;

public class TblStudent
{

   [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    
}