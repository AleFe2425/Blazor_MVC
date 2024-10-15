using Google.Cloud.Firestore;
using System.Globalization;

namespace Blazor_MVC.Models
{
    [FirestoreData]
    public class AlumnoCalificaciones
    {
        public AlumnoCalificaciones()
        {

        }

        public string AlumnoCalificacionId { get; set; }

        public Alumno Alumno { get; set; }

        [FirestoreProperty]
        public string AlumnoId { get; set; }

        [FirestoreProperty]
        public double Calificacion { get; set; }

        [FirestoreProperty]
        public string Fecha { get; set; }

        public System.DateTime GetFechaCalificacion()
        {
            return System.DateTime.ParseExact(this.Fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
