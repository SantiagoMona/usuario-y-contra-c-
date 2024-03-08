//See https://aka.ms/new-console-template for more information

/* string? name = "santiago";
string? apellido = "mona";
string? clan = "jobs";
int userID = 1234;
int contador = 0; 

do { 
    Console.Write("ingrese su nombre:");
    string? nameInput= Console.ReadLine();
    if (string.IsNullOrEmpty(nameInput)){
        System.Console.WriteLine("has ingresado vacio");
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
}  */


//int[] numerosArrays = new int[]{0,1,2,3,4,5,6,7,8,9}; //CREACION DE UNA LISTA DE NUMEROS ENTEROS 


/* ================================== */
//object[] arrayobjets = new object[]{"a",1,true};

//arrayobjets = arrayobjets.Append(Console.ReadLine()).ToArray(); // EN ESTA LINEA PUEDO AGREGAR UN OBJETO A UNA LISTA UN VALOR INGRESADO POR EL USUSARIO

/* foreach(var i in arrayobjets){

System.Console.WriteLine(i.GetType());


} */Int64 numero1;
Int64 numero2;



void Main (){
    System.Console.WriteLine("1 - suma");
    System.Console.WriteLine("2 - resta");
    System.Console.WriteLine("3 - multiplicacion");
    System.Console.WriteLine("4 - salir");
    System.Console.Write("Que operacion Desea hacer:  ");
    string? opcion = Console.ReadLine();

    if (string.IsNullOrEmpty(opcion) ){
        Console.Clear();
        System.Console.WriteLine("Ingrese una opcion VAlIDA...");
        Main();
    }

    switch (opcion)
    {
        case "1":
            Suma();
            break;
        case "2":
            resta();
            break;
        case "3":
            multiplicacion();
            break;
        case "4":
            break;
        default:
            Console.Clear();
            System.Console.WriteLine("Ingrese una opcion VAlIDA...");
            Main();
            break;
    }

}

Main();

void Suma (){
    pedirDatos();
    float suma = numero1 + numero2;
    System.Console.WriteLine($"la suma es {suma}");
    aksToUser ();
}

void resta (){
    pedirDatos();
    float resta = numero1 - numero2;
    System.Console.WriteLine($"la resta es {resta}");
    aksToUser ();
}

void multiplicacion (){
    pedirDatos();
    float multiplicacion = numero1 * numero2;
    Console.WriteLine($"la multiplicacion es {multiplicacion}");
    aksToUser ();
}

void pedirDatos () {
    System.Console.WriteLine("insegre el primer numero");
    numero1 = Convert.ToInt64(Console.ReadLine());

    if (string.IsNullOrEmpty(numero1.ToString()) ){
         System.Console.WriteLine("has ingresado vacio");
         pedirDatos();
    }

    Console.WriteLine("insegre el segundo numero");
    numero2 = Convert.ToInt64(Console.ReadLine());

    if (string.IsNullOrEmpty(numero2.ToString()) ){
        Console.WriteLine("has ingresado vacio");
        pedirDatos();
    }

}


void aksToUser (){
    System.Console.WriteLine("Desea realizar otra operacion (SI o NO)..");
    string? OptionContinio = Console.ReadLine().ToLower();

    switch (OptionContinio)
    {
        case "si":
            Console.Clear();
            Console.WriteLine("Eliga su nueva operacion a realizar");
            Main();
            break;
        case "no":
            break;
        default:
            System.Console.WriteLine("Insgrese una opcion valida");
            Console.Clear();
            aksToUser();
            break;
    }
}