# Proyecto Blazor MVC Ignacio Fonte

## Descripción del Proyecto
La aplicación de gestión académica es un proyecto diseñado para registrar, consultar y administrar la información de alumnos, sus calificaciones y su progreso académico. Está basada en el uso de **Blazor Server** para el frontend y **Firebase** para la gestión de la base de datos.

## Características Principales
- **CRUD de Alumnos:** Permite crear, leer, actualizar y eliminar alumnos.
- **CRUD de Calificaciones:** Gestión de las calificaciones de los alumnos, agrupadas por parciales.
- **Administración de Progresos Académicos:** Registro de los avances académicos (parciales) del alumno.
- **Generación de Reportes:** Reporte final que muestra el rendimiento del alumno, con cálculos y recomendaciones.
- **Interfaz Intuitiva:** Navegación clara a través de un menú bien estructurado y fácil de usar.

## Instalación

### Prerrequisitos
Asegúrate de tener instalados los siguientes elementos:
- **.NET SDK 6.0** o superior.
- **Visual Studio 2022** o **VS Code**.
- **Cuenta de Firebase:** Para la conexión con la base de datos.

### Configuración del Proyecto
1. Clonar el repositorio en tu máquina local.
2. Abrir el proyecto con **Visual Studio 2022** o **VS Code**.
3. Configurar las credenciales de **Firebase**. Reemplazar el archivo `blazorserverdb-firebase-adminsdk.json` en la carpeta `Config` con las credenciales de tu proyecto en Firebase.
4. Ejecutar el proyecto desde el IDE, seleccionando el perfil de **Blazor Server**.

## Estructura del Proyecto

- **Models:** Contiene los modelos de datos `Alumno`, `Progreso`, `AlumnoCalificaciones`, y `AlumnCalificationReport`.
- **Controllers:** Implementa la lógica de negocio a través de los controladores para cada modelo, gestionando las operaciones CRUD y la interacción con Firebase.
- **Views:** Define la interfaz de usuario, utilizando componentes Razor y las funcionalidades de Blazor para renderizar dinámicamente los datos.
- **Helpers:** Contiene utilidades como `URLHelper` para la generación dinámica de rutas.

## Tecnologías Utilizadas
- **Blazor Server-Side:** Framework para la creación de aplicaciones web interactivas usando C# y Razor.
- **Firebase:** Base de datos en tiempo real utilizada para almacenar los datos de alumnos, calificaciones y progresos.
- **.NET 6.0:** Para el desarrollo de la aplicación web y manejo del backend.
- **Blazored.Toast:** Biblioteca para la gestión de notificaciones en la interfaz.
- **CSS:** Personalización y diseño del frontend.

## Contribuciones
Las contribuciones son bienvenidas. Si deseas colaborar en este proyecto, por favor sigue las directrices estándar de GitHub para abrir *issues* o enviar *pull requests*.

## Licencia
Este proyecto está licenciado bajo los términos de la **Licencia MIT**. Consulta el archivo `LICENSE` para más detalles.

## Proyecto Desplegado
Puedes acceder al proyecto en vivo en el siguiente enlace: [Blazor MVC Deploy](https://blazormvc.azurewebsites.net/)

## Video Explicativo
Consulta el video explicativo del proyecto en YouTube: [Ver Video](https://youtu.be/eAX9pUlktW0)
