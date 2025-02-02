using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace BaseApi.Models;
public class Clientes{
    [Key]
    public Int32 id_Cliente { get; set; }
    public string? nombre { get; set; }
    public string? apellido { get; set; }
    public string? direccion { get; set; }
    public string? telefono { get; set; }
    public DateTime? fecha_nacimiento { get; set; }
    
}