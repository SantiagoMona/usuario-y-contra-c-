// See https://aka.ms/new-console-template for more information

string? name = "santiago";
string? apellido = "mona";
string? clan = "jobs";
int userID = 1234;
int contador = 0; 

do { 
    Console.Write("ingrese su nombre:");
    string? nameInput= Console.ReadLine();
    if (string.IsNullOrEmpty(nameInput)){
        System.Console.WriteLine("El nombre no coincide");
        break;
    }

    Console.Write("ingrese su contraseña:");
    string? passworInput = Console.ReadLine();

    
    if (nameInput==name )
    {
        string[] cleanPassword = passworInput.Split("-");
        Console.Clear();
        if (cleanPassword[0]==name && cleanPassword[1] == apellido && cleanPassword[2] == clan && cleanPassword[3] == Convert.ToString(userID) )
        {
            Console.WriteLine("Welcome");
            break;
        }else
        {
            Console.WriteLine("password incorret");
            contador ++;
            System.Console.WriteLine($"numeros de intentos{contador}");
        }
    }
    else
     {
        Console.WriteLine("EL usuario y/o contraseña no son los correctos");
        break;
    }
} while (contador<3);

if (contador >= 3)
{
    Console.WriteLine("Has excedido el número de intentos permitidos.");
} 