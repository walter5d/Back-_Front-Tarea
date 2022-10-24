using Microsoft.EntityFrameworkCore;
namespace web_api_1.Models{
class Conexion : DbContext{
    public Conexion(DbContextOptions<Conexion> options) : base(options){}
    public DbSet<Empleados> Empleados {get;set;}
    //aca se agregan los dbset de cada entidad o se de las entdades que representan a las tablas

}
class Conectar{
    private const string cadenaConexion="server=localhost;port=3306;database=dbempleado;pwd=Empleado@123";
    public static Conexion Create(){
        var constructor = new DbContextOptionsBuilder<Conexion>();
        constructor.UseMySQL(cadenaConexion);
        var cn = new Conexion(constructor.Options);
        return cn;

    }
}
}