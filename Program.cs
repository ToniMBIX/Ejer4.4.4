// See https://aka.ms/new-console-template for more information
int alumnos = 0;
Console.WriteLine("Cuantos estudiantes quieres calificar?");
alumnos = Int32.Parse(Console.ReadLine());
int[] Nota1 = new int[alumnos];
int[] Nota2 = new int[alumnos];
String[] Nombre = new String[alumnos];
for(int i=0; i<=alumnos-1; i++){
    Console.WriteLine("Nombre del alumno:");
    Nombre[i] = Console.ReadLine();
    Console.WriteLine("Primera nota:");
    Nota1[i] = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Segunda nota:");
    Nota2[i] = Int32.Parse(Console.ReadLine());
}
for (int i = 0; i <= alumnos-1; i++){
    Console.WriteLine("NOMBRE: "+Nombre[i]);
    Console.WriteLine("NOTA 1: "+Nota1[i]);
    Console.WriteLine("NOTA 2: "+Nota2[i]);
    Console.WriteLine("PROMEDIO: "+((Nota1[i] + Nota2[i])/2));
}