# CursoManager

Este proyecto fue creado con el objetivo de proporcionar una solución simple y efectiva para gestionar cursos y estudiantes en la Escuela ACME. En este README, explicaré los motivos detrás del diseño y la implementación de este proyecto.

## Motivación

La Escuela ACME necesitaba una manera fácil y eficiente de administrar sus cursos y alumnos. Queríamos proporcionar una solución que fuera simple de entender, fácil de mantener y escalable para futuras expansiones del negocio.

## Enfoque de Diseño

Decidí utilizar un enfoque basado en clases para la gestión de cursos y estudiantes. Esto nos permite encapsular la lógica relacionada con los cursos y los alumnos en clases separadas, lo que facilita la organización y el mantenimiento del código.

Para las pruebas unitarias, opté por utilizar xUnit, que es una herramienta popular y confiable para escribir y ejecutar pruebas en .NET Core. Esto nos permite asegurarnos de que nuestro código funcione correctamente y cumpla con los requisitos de la Escuela ACME.

## Estructura del Proyecto

El proyecto consta de dos partes principales:

1. **Proyecto de Biblioteca de Clases (.NET Core)**:
   - Contiene las clases principales para gestionar cursos y estudiantes, como `CourseManager`, `Student`, `Course`, etc.

2. **Proyecto de Pruebas Unitarias xUnit (.NET Core)**:
   - Contiene las pruebas unitarias para validar el comportamiento del proyecto principal.
   - Utilizamos mocks para simular dependencias externas y asegurar que nuestras pruebas sean independientes y consistentes.

## Ejecución de Pruebas

Para ejecutar las pruebas unitarias, simplemente sigue estos pasos:

1. Abre la solución en Visual Studio.
2. Compila el proyecto de pruebas unitarias.
3. Abre la ventana "Test Explorer" en Visual Studio.
4. Selecciona la prueba que deseas ejecutar y haz clic en el botón "Run".

## Próximos Pasos

Si la solución propuesta satisface los requisitos de la Escuela ACME y el equipo está contento con los resultados, consideraremos la posibilidad de ampliar el proyecto en el futuro. Esto podría incluir la integración con una base de datos y el desarrollo de una aplicación web para facilitar la gestión de cursos y estudiantes.

---

Este README proporciona una visión general del proyecto, los motivos detrás de su diseño y la forma de ejecutar las pruebas unitarias. Espero que esta información sea útil para comprender el proyecto y sus objetivos.