using System.ComponentModel.DataAnnotations;
namespace web_api_1.Models{
    public class Empleados{
        [Key]
        public int id_Empleado{get;set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
        public string DPI {get;set;}
        public string fecha_nacimiento {get;set;}
        public int id_puesto {get;set;}
        public string Fecha_ingreso_registro  {get;set;}
    }
}