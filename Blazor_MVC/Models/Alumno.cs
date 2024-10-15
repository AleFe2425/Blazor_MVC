using Google.Cloud.Firestore;

namespace Blazor_MVC.Models
{
    [FirestoreData]
    public class Alumno
    {
        public Alumno()
        {

        }

        public string AlumnoId { get; set; }

        [FirestoreProperty]
        public string Nombre { get; set; }
    }
}
