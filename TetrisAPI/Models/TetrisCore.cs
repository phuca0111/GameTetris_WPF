using System.ComponentModel.DataAnnotations;
namespace TetrisAPI.Models{
    public class TetrisCore{
        [Key]
        [Required]        
        public int Id {get;set;}
        [Required]   
        public string? NamePlayer { get; set; }
        [Required]
        public int Score { get; set; }
        
        [Required]
        public DateTime GameTime { get; set;}
    }
}