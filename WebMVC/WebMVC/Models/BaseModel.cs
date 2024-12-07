namespace WebMVC.Models;

public class BaseModel
{
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime UpdatedDate { get;set; } = DateTime.Now;
    public virtual User? CreatedBy { get; set; } = null;
    public virtual User? UpdatedBy { get; set; } = null;

}
