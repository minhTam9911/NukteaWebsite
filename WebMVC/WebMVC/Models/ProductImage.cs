using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models;

public  class ProductImage : BaseModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Path { get; set; } = string.Empty;
    public virtual Product? Product { get; set; }
}
