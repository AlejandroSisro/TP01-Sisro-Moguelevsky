namespace TP01-Sisro-Moguelevsky
{
    public class Grupo
    {
        private Dictionary <int, Integrante> integrantes = new Dictionary <int, Integrante>();
    
        public Grupo()
        {
        Dictionary <int, Alumno> integrantes = new Dictionary <int, Alumno>();
        CargaDatosManual();
        } 
        private void CargaDatosManual()
        {
            Integrante Alumno1 = new Integrante(50434049, "Alejandro", "21/06/2010", "Ale.jpg");
            Integrante Alumno2 = new Integrante(50233806, "Ezequiel", "15/03/2010", "Echu.jpg");
            integrantes.Add(Alumno1);
            integrantes.Add(Alumno2);
        }
        public Dictionary<int,Integrante> DevolverIntegrantes()
        {
            return integrantes;
        }
        public Integrante GetIntegrantes(int dni)
        {
            if(integrantes.ContainsKey(dni) = true)
            {
                return integrantes[dni];
            }
            else
            {
                return null;
            }
        }
    }
   
}
