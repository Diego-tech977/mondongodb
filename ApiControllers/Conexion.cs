using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using MongoDB.Driver;

[ApiController]
[Route("conexion")]
public class Conexion : Controller 
{
    [HttpGet ("sql")]
    public IActionResult ListarPersonajesSql()
    {
        return Ok("DragonBall a SQL Server");
    }

    [HttpGet("mongo")]
    public IActionResult PersonajesMongoDb(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Practica2_Giovanni_Diego");
        var collection = db.GetCollection<PersonajesMongo>("Dragon_Ball");

        var lista = collection.Find(FilterDefinition<PersonajesMongo>.Empty).ToList();

        return Ok(lista);
    }    
}