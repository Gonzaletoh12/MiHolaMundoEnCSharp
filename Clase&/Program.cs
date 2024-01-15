using Clase_;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado("A2323", 54989698, "Gonzalo Bentancor", "Millan 3552");
        Estudiante estudiante1 = new Estudiante("Ingenieria en computacion", 256525, "Juan Perez", "Lamadeo 445");
        Persona persona1 = empleado1;
        Persona persona2 = estudiante1;
        // Estudiante estudiante2 = persona1; no puedo asignar un padre a su hijo!!!
        persona1.MostrarDatos();
        empleado1.MostrarDatos();
        estudiante1 .MostrarDatos();

        Persona.TelefonoEmargencia();
          
        Console.WriteLine(Calculadora.Suma(2,2));

        Cubo cubo = new(1);
        Rectangulo rectangulo = new(2, 2);
        Circulo circulo = new(2);

        Console.WriteLine("Volumen Cubo" + cubo.Volumen() + 
                          "\nPerimetro rectangulo:" + rectangulo.Perimetro()
                          + "\nArea Circulo:" + circulo.Area());
        Console.WriteLine("Esto es un cambio para probar el repositorio");
        
        Console.WriteLine();
    }
}