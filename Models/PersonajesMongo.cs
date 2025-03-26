using MongoDB.Bson.Serialization.Attributes;

public class PersonajesMongo {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    
    public string? Id { get; set; }
    public string Personaje { get; set; } = "";
    public int Velocidad { get; set; }
    public string? Tecnica { get; set; }
    public int NvlPoder { get; set; }
    public decimal Altura { get; set; }
    public string? Transformaciones { get; set; }
    public string? Casado { get; set; }
     public string Gustos { get; set; } = "";
}