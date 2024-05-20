
using System.Xml;

string[] nombres = new string[]
        {
            "Ana", "Bruno", "Carlos", "Diana", "Elena", "Felipe", "Gabriela", "Hector", "Isabel", "Jorge",
            "Karla", "Luis", "Marta", "Nestor", "Olga", "Pablo", "Queta", "Roberto", "Sandra", "Tomas",
            "Ursula", "Victor", "Wendy", "Ximena", "Yolanda", "Zacarias", "Andrea", "Benjamin", "Camila", "David",
            "Eva", "Federico", "Gloria", "Hernan", "Ines", "Jaime", "Laura", "Manuel", "Nina", "Oscar"
        };

string[] direcciones = new string[]
{
            "Calle A #1", "Calle B #2", "Calle C #3", "Calle D #4", "Calle E #5", "Calle F #6", "Calle G #7", "Calle H #8", "Calle I #9", "Calle J #10",
            "Calle K #11", "Calle L #12", "Calle M #13", "Calle N #14", "Calle O #15", "Calle P #16", "Calle Q #17", "Calle R #18", "Calle S #19", "Calle T #20",
            "Calle U #21", "Calle V #22", "Calle W #23", "Calle X #24", "Calle Y #25", "Calle Z #26", "Calle AA #27", "Calle BB #28", "Calle CC #29", "Calle DD #30",
            "Calle EE #31", "Calle FF #32", "Calle GG #33", "Calle HH #34", "Calle II #35", "Calle JJ #36", "Calle KK #37", "Calle LL #38", "Calle MM #39", "Calle NN #40"
};

string[] telefonos = new string[]
{
            "555-0101", "555-0102", "555-0103", "555-0104", "555-0105", "555-0106", "555-0107", "555-0108", "555-0109", "555-0110",
            "555-0111", "555-0112", "555-0113", "555-0114", "555-0115", "555-0116", "555-0117", "555-0118", "555-0119", "555-0120",
            "555-0121", "555-0122", "555-0123", "555-0124", "555-0125", "555-0126", "555-0127", "555-0128", "555-0129", "555-0130",
            "555-0131", "555-0132", "555-0133", "555-0134", "555-0135", "555-0136", "555-0137", "555-0138", "555-0139", "555-0140"
};

string[] nivelesEstudio = new string[]
{
            "Primaria", "Secundaria", "Bachillerato", "Universidad", "Maestría", "Doctorado", "Primaria", "Secundaria", "Bachillerato", "Universidad",
            "Maestría", "Doctorado", "Primaria", "Secundaria", "Bachillerato", "Universidad", "Maestría", "Doctorado", "Primaria", "Secundaria",
            "Bachillerato", "Universidad", "Maestría", "Doctorado", "Primaria", "Secundaria", "Bachillerato", "Universidad", "Maestría", "Doctorado",
            "Primaria", "Secundaria", "Bachillerato", "Universidad", "Maestría", "Doctorado", "Primaria", "Secundaria", "Bachillerato", "Universidad"
};

double[] dinero = new double[]
{
            1200.50, 850.75, 950.00, 1250.30, 1020.90, 1600.40, 750.60, 890.50, 1100.00, 1150.20,
            1300.15, 1400.45, 1500.55, 920.80, 980.95, 1350.70, 1440.10, 1550.85, 1650.20, 1050.00,
            1750.35, 1850.50, 1950.75, 2050.90, 2150.65, 2250.80, 2350.95, 2450.10, 2550.25, 2650.40,
            2750.55, 2850.70, 2950.85, 3050.00, 3150.15, 3250.30, 3350.45, 3450.60, 3550.75, 3650.90
};

Console.WriteLine("Empresa uwu");
Console.WriteLine("Bienvenide");
Console.WriteLine("1. Buscar datos del cliente");
Console.WriteLine("2. Cliente con mayor ingreso");
Console.WriteLine("3. Cliente con menor ingreso");
Console.WriteLine("4. Salir");
byte opc = Convert.ToByte(Console.ReadLine());

switch (opc)
{
        case 1:
        Console.WriteLine("Ingrese nombre del cliente");
        string NombreCliente = Console.ReadLine();
        for (int i = 0;i<nombres.Length; i++)
        if (NombreCliente == nombres[i])
            {
                Console.WriteLine("Cliente>>" + nombres[i]);
                Console.WriteLine("Informacion del cliente:");
                Console.WriteLine("Direccion        >> " + direcciones[i]);
                Console.WriteLine("Telefono         >> " + telefonos[i]);
                Console.WriteLine("Nivel de estudio >> " + nivelesEstudio[i]);
                
            }
        else
            {
                Console.WriteLine(NombreCliente+" no se encuentra registrado.");
                break;
            }
            break;
}