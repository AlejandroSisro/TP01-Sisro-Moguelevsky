namespace TP01-Sisro-Moguelevsky
{
    public class Grupo
    {
        private Dictionary <int, Integrante> Integrantes = new Dictionary <int, Integrante>();
    
        public Grupo()
        {
        Dictionary <int, Alumno> Integrantes = new Dictionary <int, Alumno>();
        CargaDatosManual();
        } 
        private void CargaDatosManual()
        {
            Integrante Alumno1 = new Integrante(50434049, "Alejandro", "21/06/2010", "Ale");
            Integrante Alumno2 = new Integrante(50233806, "Ezequiel", "15/03/2010", "Echu");
            Integrantes.Add(Alumno1);
            Integrantes.Add(Alumno2);
        }
        public Dictionary<int,Integrante> DevolverIntegrantes()
        {
            return Integrantes;
        }
        public int GetIntegrantes(int dni)
        {

        }
    }
   
}
