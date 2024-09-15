namespace Estudiantes.Tests;

public class PruebaEstudiante2
{
    [SetUp]
    public void Setup()
    {
    }

    // ---------- PRUEBAS UNITARIAS INCISO 1 ---------- //
    [Test]
    public void TestNombreMenor10()
    {
        var niEstudiante = new Estudiante() {nombre = "Victor", Punteo = 85, Carrera = "Ingenieria"};
        Assert.IsFalse(niEstudiante.EstudianteValido());
        Assert.IsTrue(niEstudiante.Errores.Any());
        Assert.IsTrue(niEstudiante.Errores.Contains("El Nombre del Estudiante es Muy Corto"));
    }

    [Test]
    public void TestNombreCorrecto()
    {
        var niEstudiante = new Estudiante() {nombre = "Victor Andres Vasquez Hernandez", Punteo = 85, Carrera = "Ingenieria"};
        Assert.IsTrue(niEstudiante.EstudianteValido());
        Assert.IsFalse(niEstudiante.Errores.Any());
    }


     // ---------- PRUEBAS UNITARIAS INCISO 2 ---------- //
     // ------------------------------------------------ //
    [Test]
    public void TestCarreraNoPermitida()
    {
        var niEstudiante = new Estudiante() { nombre = "Victor Andres Vasquez Hernandez", Punteo = 85, Carrera = "Historia" };
        Assert.IsFalse(niEstudiante.EstudianteValido());
        Assert.IsTrue(niEstudiante.Errores.Contains("La Carrera Ingresada no es Permitida"));
    }

    [Test]
    public void TestCarreraPermitida()
    {
        var niEstudiante = new Estudiante() { nombre = "Victor Andres Vasquez Hernandez", Punteo = 85, Carrera = "Ingenieria" };
        Assert.IsTrue(niEstudiante.EstudianteValido());
        Assert.IsFalse(niEstudiante.Errores.Any());
    }




    // ---------- PRUEBAS UNITARIAS INCISO 3 ---------- //
    // ------------------------------------------------ //
    [Test]
    public void TestEstudianteGanaMedicina()
    {
        var estudiante = new Estudiante() { nombre = "Victor Andres Vasquez Hernandez", Punteo = 85, Carrera = "Medicina" };
        Assert.IsTrue(estudiante.EstudianteGana());
    }

    [Test]
    public void TestEstudianteGanaIngenieria()
    {
        var estudiante = new Estudiante() { nombre = "Victor Andres Vasquez Hernandez", Punteo = 70, Carrera = "Ingenieria" };
        Assert.IsTrue(estudiante.EstudianteGana());
    }

    [Test]
    public void TestEstudiantecMedicina()
    {
        var estudiante = new Estudiante() { nombre = "Victor Andres Vasquez Hernandez", Punteo = 70, Carrera = "Medicina" };
        Assert.IsFalse(estudiante.EstudianteGana());
    }

    [Test]
    public void TestEstudiantePierdeIngenieria()
    {
        var estudiante = new Estudiante() { nombre = "Victor Andres Vasquez Hernandez", Punteo = 55, Carrera = "Ingenieria" };
        Assert.IsFalse(estudiante.EstudianteGana());
    }





    // ---------- PRUEBAS UNITARIAS INCISO 4 ---------- //
    // ------------------------------------------------ //
    [Test]
    public void TestPunteoNoPermitido()
    {
        var estudiante = new Estudiante() { nombre = "Victor Andres Vasquez Hernandez", Punteo = 101, Carrera = "Ingenieria" };
        Assert.IsFalse(estudiante.EstudianteValido());
        Assert.IsTrue(estudiante.Errores.Contains("El punteo del estudiante no puede ser mayor a 100"));
    }

    [Test]
    public void TestPunteoPermitido()
    {
        var estudiante = new Estudiante() { nombre = "Victor Andres Vasquez Hernandez", Punteo = 99, Carrera = "Ingenieria" };
        Assert.IsTrue(estudiante.EstudianteValido());
    }



    // ---------- PRUEBAS UNITARIAS INCISO 5 ---------- //
    // ------------------------------------------------ //

    [Test]
    public void TestNombreRequerido()
    {
        var estudiante = new Estudiante() { nombre = "", Punteo = 85, Carrera = "Ingenieria" };
        Assert.IsFalse(estudiante.EstudianteValido());
        Assert.IsTrue(estudiante.Errores.Contains("El nombre del estudiante es requerido"));
    }

    [Test]
    public void TestPunteoRequerido()
    {
        var estudiante = new Estudiante() { nombre = "Victor Andres Vasquez Hernandez", Punteo = 0, Carrera = "Ingenieria" };
        Assert.IsFalse(estudiante.EstudianteValido());
        Assert.IsTrue(estudiante.Errores.Contains("El punteo del estudiante es requerido"));
    }

    [Test]
    public void TestCarreraRequerida()
    {
        var estudiante = new Estudiante() { nombre = "Victor Andres Vasquez Hernandez", Punteo = 85, Carrera = "" };
        Assert.IsFalse(estudiante.EstudianteValido());
        Assert.IsTrue(estudiante.Errores.Contains("La carrera del estudiante es requerida"));
    }


}