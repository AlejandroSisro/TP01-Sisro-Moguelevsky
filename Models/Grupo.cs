namespace TP01-Sisro-Moguelevsky
{
    public class Grupo
    {
    private Dictionary <int, Integrante> dicAlumnos = new Dictionary <int, Integrante>();

    public Grupo()
    {
    Dictionary <int, Alumno> dicAlumnos = new Dictionary <int, Alumno>();
    } 
    public void CargaDatosManual()
    {
        Integrante Alumno1 = new Integrante(50434049, "Alejandro", "21/06/2010", "Ale");
        Integrante Alumno2 = new Integrante(50233806, "Ezequiel", "15/03/2010", "Echu");
        dicAlumnos.Add(Alumno1);
        dicAlumnos.Add(Alumno2);
    }
       public void DevolverIntegrantes()
    {
          foreach(Dictionary objDic in Integrante.Values)
            {
                Console.WriteLine(objDic.Alumno1); 
                Console.WriteLine(objDic.Alumno2); 
            }
        
    }
    }
   
}
