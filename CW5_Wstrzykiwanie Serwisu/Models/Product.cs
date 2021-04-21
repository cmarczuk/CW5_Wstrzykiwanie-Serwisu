using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CW5_Wstrzykiwanie_Serwisu.Models
{
    public class Product
    {
        [Column(TypeName = "integer")]
        [JsonIgnore]
        public int Id { get; set; }

        [Column(TypeName = "varchar(64)"), MaxLength(64)]
        [JsonPropertyName("id")]
        public string Id_json { get; set; }

        [Column(TypeName = "varchar(128)"), MaxLength(128)]
        [JsonPropertyName("maker")]
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        [Column(TypeName = "varchar(255)"), MaxLength(255)]
        public string Image { get; set; }

        [Column(TypeName = "varchar(255)"), MaxLength(255)]
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [Column(TypeName = "varchar(255)"), MaxLength(255)]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [Column(TypeName = "varchar(255)"), MaxLength(255)]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}