// See https://aka.ms/new-console-template for more information

var est = new Estudiantes();
est.Id = 1;
est.Nombre = "Pepito";
est.Edad = 19;
est.Carrera = "Desarrollo de software";
est.Cursos = new List<Cursos>();
est.Cursos.Add(new Cursos { Id = 1, Nombre = "Base de datos", Creditos = 5 });
est.Cursos.Add(new Cursos { Id = 2, Nombre = "Programacion", Creditos = 3 });
est.Cursos.Add(new Cursos { Id = 3, Nombre = "Calculo Integral", Creditos = 2 });

Console.WriteLine("Id Estudiante: " + est.Id);
Console.WriteLine("Nombre Estudiante: " + est.Nombre);
Console.WriteLine("Cursos inscritos: ");
foreach (var i in est.Cursos)
{
    Console.WriteLine(i.Nombre);
}

var pro = new Profesores();
pro.Id = 1;
pro.Nombre = "Juan Carlos";
pro.Edad = 35;
pro.Especialidad = "Programacion de software";

Console.WriteLine("Docente: " + pro.Nombre + ", Especialidad: " + pro.Especialidad);
public class Cursos
{
    public int Id;
    public string Nombre = "";
    public int Creditos = 0;
}

public class Personas
{
    public int Id;
    public string Nombre = "";
    public int Edad = 0;
}

public class Profesores : Personas
{
    public string Especialidad = "";
}

public class Estudiantes : Personas
{
    public string Carrera = "";
    public List<Cursos>? Cursos;
}