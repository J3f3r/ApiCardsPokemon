using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonCardsAPI.Models
{
    [Table("tbl_collections")]
    public class Collection
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("collectionSetName")]
        public string CollectionSetName { get; set; } = string.Empty;

        [Column("releaseDate")]
        public DateTime ReleaseDate { get; set; }

        [Column("totalCardsInCollections")]
        public int TotalCardsInCollections { get; set; }
    }
}