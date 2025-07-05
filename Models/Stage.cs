using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonCardsAPI.Models
{
    [Table("tbl_stages")]
    public class Stage
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("stageName")]
        public string StageName { get; set; } = string.Empty;
    }
}