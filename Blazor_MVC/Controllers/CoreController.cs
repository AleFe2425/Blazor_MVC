using Google.Cloud.Firestore.V1;
using Blazor_MVC.Models;

namespace Blazor_MVC.Controllers
{
    public class CoreController
    {
        public static async Task<List<AlumnCalificationReport>> BuildReporteAlumnosCalifición()
        {
            List<AlumnCalificationReport> listaToReturn = new List<AlumnCalificationReport>();

            ProgresoController progresoController = new ProgresoController();
            AlumnoController alumnoController = new AlumnoController();
            AlumnoCalificacionController alumnoCalificacionController = new AlumnoCalificacionController();

            List<Progreso> progresos = new List<Progreso>();
            List<Alumno> alumnos = new List<Alumno>();
            List<AlumnoCalificaciones> alumnoCalificaciones = new List<AlumnoCalificaciones>();

            // Obtener los progresos, alumnos y calificaciones
            progresos = await progresoController.GetAllProgresos();
            progresos = progresos.OrderBy(p => p.NumeroProgreso).ToList();

            alumnos = await alumnoController.GetAllAlumnos();
            alumnoCalificaciones = await alumnoCalificacionController.GetAllAlumnosCalificacion();

            // Crear el reporte por alumno
            foreach (Alumno alumno in alumnos)
            {
                AlumnCalificationReport ACLoop = new AlumnCalificationReport();
                ACLoop.alumn = alumno;

                // Filtrar calificaciones del alumno
                List<AlumnoCalificaciones> calificacionesDelAlumno = alumnoCalificaciones
                    .Where(ac => ac.AlumnoId == alumno.AlumnoId).ToList();

                // Asignar las calificaciones al progreso correspondiente
                foreach (AlumnoCalificaciones alumnoClif in calificacionesDelAlumno)
                {
                    if (progresos[0].GetFechaInicioProgreso() <= alumnoClif.GetFechaCalificacion() &&
                        alumnoClif.GetFechaCalificacion() <= progresos[0].GetFechaFinProgreso())
                    {
                        ACLoop.alumnoCalificacionesP1.Add(alumnoClif);
                    }
                    if (progresos[1].GetFechaInicioProgreso() <= alumnoClif.GetFechaCalificacion() &&
                        alumnoClif.GetFechaCalificacion() <= progresos[1].GetFechaFinProgreso())
                    {
                        ACLoop.alumnoCalificacionesP2.Add(alumnoClif);
                    }
                    if (progresos[2].GetFechaInicioProgreso() <= alumnoClif.GetFechaCalificacion() &&
                        alumnoClif.GetFechaCalificacion() <= progresos[2].GetFechaFinProgreso())
                    {
                        ACLoop.alumnoCalificacionesP3.Add(alumnoClif);
                    }
                }

                listaToReturn.Add(ACLoop);
            }

            return listaToReturn;
        }
    }
}
