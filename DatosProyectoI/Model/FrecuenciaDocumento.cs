namespace DatosProyectoI.Model
{
    /*
        Almacena la frecuencia de un t�rmino en un documento espec�fico
        Esta clase es utilizada en el �ndice invertido para almacenar la informaci�n de frecuencia de 
        t�rminos por documento.
     */
    public class FrecuenciaDocumento
    {
        public int DocId { get; set; }
        public int Frecuencia { get; set; }
        
        public FrecuenciaDocumento(int d, int f)
        {
            DocId = d;
            Frecuencia = f;
        }
    }
}
