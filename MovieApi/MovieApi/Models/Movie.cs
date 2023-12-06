using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models;
public class Movie {
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "The title of the movie is mandatory")]
    public string Title { get; set; }

    [Required(ErrorMessage = "The Genre of the movie is mandatory")]
    [MaxLength(50, ErrorMessage = "The lenght of the genre cannot exceed 50 characters")]
    public string Genre { get; set; }

    [Required]
    public int Duration { get; set; }
}
