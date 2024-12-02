// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var superman = new superHero();

superman.ciudad = "florencia";
superman.id = 1;
superman.name = "SuperMan";
superman.identidadSecreta = "Clark";
superman.puedeVolar = true;
superman.poderes = new[] { "fuerza", "velocidad", "rayos" };



class superHero
{
    public int id;
    public String name;
    public string identidadSecreta;
    public string ciudad;
    public String[] poderes;
    public bool puedeVolar;
}

Console.WriteLine(superman);

