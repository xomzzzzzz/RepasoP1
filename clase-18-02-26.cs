Console.WriteLine("Clase 18-02-2026");
var vehiculo = new Vehiculos()
{
    id = 1,
    placa = "JHG678"
};
vehiculo.marca = new Marcas() { id = 1, nombre = "KIA" };
vehiculo.tipos = new List<Tipos>();
vehiculo.tipos.Add(new Tipos() { id = 1, nombre = "HIBRIDO" });
vehiculo.tipos.Add(new Tipos() { id = 2, nombre = "ELECTRICO" });

Console.WriteLine("id: " + vehiculo.id + ", " +
    "placa: " + vehiculo.placa + ", " +
    "kilometraje: " + vehiculo.kilometraje + ", " +
    "modelo: " + vehiculo.modelo + ", " +
    "activo: " + vehiculo.activo + ", " +
    "marca: " + vehiculo.marca.nombre);

foreach (var elemento in vehiculo.tipos)
{
    Console.WriteLine("id: " + elemento.id + ", " +
        "nombre: " + elemento.nombre);
}

// Polimorfismo
Personas persona = new Personas() { nombre = "Juan" };
Personas estudiante = new Estudiantes() { nombre = "Santiago" };
Personas profesor = new Profesores() { nombre = "Samuel" };

// Clases
public class Marcas
{
    // Atributos y Propiedades
    public int id { get; set; }
    public string? nombre { get; set; }
}

// Clases
public class Tipos
{
    // Atributos y Propiedades
    public int id { get; set; }
    public string? nombre { get; set; }
}

// Clases
public class Vehiculos
{
    // Atributos
    public int id = 0;
    public string placa = "";
    public decimal kilometraje = 0.0m;
    public DateTime modelo = DateTime.Now;
    public bool activo = true;
    public Marcas? marca = null;
    public List<Tipos>? tipos = null;

    // Constructor
    public Vehiculos() { }

    // Propiedades
    public int Id
    {
        set { this.id = value; }
        get { return this.id; }
    }

    // Metodos
    public int GetId() { return this.id; }
}

// Herencia y Polimorfismo
public class Personas
{
    private int id = 0; // Encapsulado
    protected string cedula = ""; // Encapsulado
    public string nombre = "";
}

public class Estudiantes : Personas
{
    public void SetCedula(string value) { this.cedula = value; }
    public string GetCedula() { return this.cedula; }
}

public class Profesores : Personas
{

}
