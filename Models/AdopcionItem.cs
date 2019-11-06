namespace MascotasApp.Models
{
    public class AdopcionItem
    {
        public int Id { get; set; }
        public long Cod_Personna{get;set;}
        public string NombreCompleto{get;set;}
        public long Telefono{get; set;}
        public string Direccion {get; set;}
        public string Sexo{get; set;}
        public int Edad{get; set;}
    }
}