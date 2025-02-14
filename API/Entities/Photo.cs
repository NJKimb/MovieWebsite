using System.ComponentModel.DataAnnotations.Schema;
using MovieAPI.Entities;

namespace API.Entities;

[Table("Photos")]
public class Photo
{
    public int Id { get; set; }
    public required string Url { get; set; }
    public bool IsMain { get; set; }

    //Navigation Properties
    public int MovieId { get; set; }
    public Movie Movie { get; set; } = null!;
}
