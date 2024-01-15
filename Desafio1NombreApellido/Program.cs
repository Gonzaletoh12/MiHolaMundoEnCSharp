using System;

string comision;
int nota = 0;
Console.WriteLine("Ingrese la comision del alumno");
comision = Console.ReadLine();

switch (comision) {
    case "A":
        Console.WriteLine("El alumno tiene turno en la mañana");
        break;
    case "B":
        Console.WriteLine("El alumno tiene turno en la tarde");
        break;
    case "C":
        Console.WriteLine("El alumno tiene turno en la noche");
        break;
    default:
        Console.WriteLine("El alumno no tiene turno fijado");
        break;
}

Console.WriteLine("Ingrese la nota del alumno");
nota = Convert.ToInt32(Console.ReadLine());

if (nota < 4)
{
    Console.WriteLine("El alumno de comisión recursa la materia");
}
else if (nota <= 7)
{
    Console.WriteLine("El alumno de comisión aprueba la cursada");
}
else {
    Console.WriteLine("El alumno de comisión promociona la materia");
}

Console.ReadKey();