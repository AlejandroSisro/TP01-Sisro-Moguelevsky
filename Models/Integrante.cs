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
        familiares = new List<string>();
        intereses = new List<string>();
    } 
    public string getName()
    {
        return nombre;
    }
    public string getImage()
    {
        return foto;
    }
    public int getID()
    {
        return dni;
    }
    public date getDate()
    {
        return fechaNacimiento;
    }
    public List<string> getRelatives()
    {
        return familiares;
    }
    public List<string> getInterests()
    {
        return intereses;
    }
    }
}    
