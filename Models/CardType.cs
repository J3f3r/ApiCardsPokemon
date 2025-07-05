using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonCardsAPI.Models
{
    [Table("tbl_types")]
    public class CardType
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("typeName")]
        public string TypeName { get; set; } = string.Empty;
    }
}