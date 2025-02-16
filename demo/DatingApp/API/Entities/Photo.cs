using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

[Table("Photos")]
public class Photo
{
    public int Id { get; set; }
    public required string Url { get; set; }    
    public Boolean IsMain { get; set; }
    public string? PublicId { get; set; }
    public int AppUserID { get; set; }
    public AppUser AppUser { get; set; } = null!;
}