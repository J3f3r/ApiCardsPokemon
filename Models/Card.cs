using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonCardsAPI.Models
{
    [Table("tbl_cards")] // Mapeia a classe à tabela existente no SQL Server
    public class Card
    {
        [Key] // Define como chave primária
        [Column("id")] // Coluna real no banco
        public int Id { get; set; }

        [Required]
        [Column("name")] // Nome do card (Ex: Pikachu)
        public string Name { get; set; } = string.Empty;

        [Column("typeId")] // FK → tbl_types
        public int TypeId { get; set; }

        [Column("stageId")] // FK → tbl_stages
        public int StageId { get; set; }

        [Column("info")] // Informações adicionais
        public string Info { get; set; } = string.Empty;

        [Column("attack")] // Nome do ataque
        public string Attack { get; set; } = string.Empty;

        [Column("dammage")] // Dano causado (mantido como no banco)
        public string Dammage { get; set; } = string.Empty;

        [Column("weak")] // Fraqueza
        public string Weak { get; set; } = string.Empty;

        [Column("resis")] // Resistência
        public string Resis { get; set; } = string.Empty;

        [Column("retreat")] // Custo de retirada
        public string Retreat { get; set; } = string.Empty;

        [Column("cardNumberInCollection")] // Número do card na coleção (Ex: 1/102)
        [Required]
        [MaxLength(10)] // Limita o tamanho máximo do número do card
        public string CardNumberInCollection { get; set; } = string.Empty;

        [Column("collectionId")] // FK → tbl_collections
        public int CollectionId { get; set; }

        // 🔗 Navigation properties (relacionamentos)
        [ForeignKey("TypeId")]
        public CardType? Type { get; set; }

        [ForeignKey("StageId")]
        public Stage? Stage { get; set; }

        [ForeignKey("CollectionId")]
        public Collection? Collection { get; set; }
    }
}