namespace TP01-Sisro-Moguelevsky
{
    public class Integrante
    {
    private int dni;
    private string nombre;
    private date fechaNacimiento;
    private string foto;
    private List<string> Familiares;
    private List<string> Intereses;

    public Integrante(int dni, string nombre, date fechaNacimiento, string foto)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.foto = foto;
        <string> Familiares = new List<string>();
        <string> Intereses = new List<string>();
    } 
    
    }
}    
