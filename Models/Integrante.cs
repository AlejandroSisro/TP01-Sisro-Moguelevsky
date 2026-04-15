namespace TP01-Sisro-Moguelevsky
{
    public class Integrante
    {
      private int dni;
      private string Nombre;
      private string fechaDnacimiento;
      private string foto;
      private List<string> Familiares;
      private List<string> Intereses;
      public  Integrante(int dni,string Nombre,string fechaDnacimiento,string foto)
      {
        this.dni=dni;
        this.Nombre=Nombre;
        this.fechaDnacimiento=fechaDnacimiento;
        this.foto=foto;
        List<string> Familiares = new List<string>;
        List<string>  Intereses = new List<string>;
      } 
      
    }
}
