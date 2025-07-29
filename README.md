Patrón Observer en C#

Descripción
Este proyecto implementa el patrón de diseño **Observer**, el cual define una dependencia de uno a muchos entre objetos, de modo que cuando uno cambie de estado, todos sus dependientes sean notificados automáticamente.

Es ideal para situaciones donde múltiples objetos necesitan reaccionar a un cambio en otro objeto, como en sistemas de eventos, notificaciones o interfaces reactivas.

Este ejemplo forma parte de una colección de patrones de diseño desarrollados para práctica y aprendizaje en C#.

Tecnologías utilizadas
- C#
- .NET (Consola)
- Visual Studio

Cómo ejecutar
1. Cloná el repositorio o descargalo como ZIP.
2. Abrí el proyecto en Visual Studio.
3. Ejecutá el archivo `Program.cs`.
4. Observá la salida en la consola.

Ejemplo de salida esperada
```plaintext
El sujeto Juan suscripto al observador
El sujeto Juan desuscripto al observador
El sujeto Juan suscripto al observador
El sujeto Carlos suscripto al observador 
Soy Juan recibiendo notificacion estado bateria: 44%
Soy Carlos recibiendo notificacion estado bateria: 44%
