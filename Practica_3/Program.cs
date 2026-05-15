using Practica_3;

class Program
{
    static async Task Main(string[] args)
{
    IUserService service = new UserService();

    bool continuar = true;

    while (continuar)
    {
        Console.Clear();

        Console.Write("¿Cuántos usuarios deseas obtener?: ");
        int cantidad = int.Parse(Console.ReadLine());

        List<Task<User>> tareas = new List<Task<User>>();

        Console.WriteLine("\nBuscando usuarios...\n");

        // Crear tareas concurrentes
        for (int i = 0; i < cantidad; i++)
        {
            tareas.Add(service.GetUserAsync());
        }

        // Esperar todas las tareas
        User[] usuarios = await Task.WhenAll(tareas);

        // Mostrar resultados
        for (int i = 0; i < usuarios.Length; i++)
        {
            User usuario = usuarios[i];

            if (usuario != null)
            {
                Console.WriteLine($"Usuario #{i + 1}");
                Console.WriteLine($"Nombre : {usuario.Name.First} {usuario.Name.Last}");
                Console.WriteLine($"Género : {usuario.Gender}");
                Console.WriteLine($"Correo : {usuario.Email}");
                Console.WriteLine($"País   : {usuario.Location.Country}");
                Console.WriteLine();
            }
        }

        Console.WriteLine("¿Deseas buscar más usuarios?");
        Console.WriteLine("1 - Sí");
        Console.WriteLine("2 - Salir");

        Console.Write("Opción: ");
        string opcion = Console.ReadLine();

        continuar = opcion == "1";
    }

    Console.WriteLine("\nPrograma finalizado.");
}
    }