namespace TP01-Sisro-Moguelevsky
{
    public class Grupo
    {
    private Dictionary <int, Alumno> dicAlumnos = new Dictionary <int, Alumno>();

      public Grupo()
      {
        Dictionary <int, Alumno> dicAlumnos = new Dictionary <int, Alumno>();
      } 
       
       public void DevolverIntegrantes()
    {
          foreach(Dictionary objDic in dicAlumnos.Values)
            {
                Console.WriteLine(objDic.getDni()); 
                Console.WriteLine(objDic.Alumno); 
                Console.WriteLine(obj.Alumno); 
            }
        
    }
    }
   
}