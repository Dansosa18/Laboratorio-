Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\t\tVictor  Daniel Sosa Lopez\t\t 0905-23-8230\n");
Console.ResetColor();

///Conversión de tipos:
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("----CONVERSION DE TIPOS----\n");
Console.ResetColor();


//convierta un número entero a decimal.
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("CONVERTIR ENTERO A DECIMAL\n");
Console.ResetColor();

Console.WriteLine("Escriba el numero Entero");
string nentero = Console.ReadLine();
decimal ndec = decimal.Parse(nentero);
Console.WriteLine("El Número decimal es: {0}", ndec);

Console.WriteLine("\n********************** \n");

//Convertir un numero Decimal a Flotante
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("CONVERTIR DECIMAL A FLOTANTE\n");
Console.ResetColor();

Console.WriteLine("Escriba el numero Decimal");
string ndec1 = Console.ReadLine();
float nflo=float.Parse(ndec1);
Console.WriteLine("El numero convertido a Flotante es: {0} \n", nflo);

Console.WriteLine("********************** \n");

//Convertir numero flotante a entero 
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("CONVERTIR FLOTANTE A ENTERO\n");
Console.ResetColor();

Console.WriteLine("Escriba el Numero Flotante:");
string numfloat = Console.ReadLine();

int nument=(int)float.Parse(numfloat);
Console.WriteLine("El numero convertido a entero es: {0}",nument);
Console.WriteLine("\n");

Console.WriteLine("********************** \n");

//Convertir caracter a entero

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("CONVERTIR CARACTER A ENTERO\n");
Console.ResetColor();

Console.WriteLine("Escriba el caracter");
char cara= Console.ReadKey().KeyChar;
int numeroentero = cara -'0';
Console.WriteLine("\nEl numero entero es: {0}\n",numeroentero);

Console.WriteLine("********************** \n");

//Convertir entero a caracter
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("CONVERTIR ENTERO A CARACTER\n");
Console.ResetColor();


Console.WriteLine("Escriba el entero");
int nenter= int.Parse(Console.ReadLine());
char car = (char)(nenter + '0');
Console.WriteLine("El caracter es:{0}\n",car);

Console.WriteLine("********************** \n");

///Operaciones con tipos de datos:

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("----OPERACIONES CON TIPOS DE DATOS----\n");
Console.ResetColor();

//suma de dos números enteros

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("SUMA\n");
Console.ResetColor();

int num1 = 0;
int num2 = 0;

Console.WriteLine("Escriba un numero");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
num2 = int.Parse(Console.ReadLine());
int resultadosuma = num1 + num2;

Console.WriteLine($"La suma de los 2 numeros es:" + resultadosuma);
Console.WriteLine("\n");

Console.WriteLine("********************** \n");

//resta de dos números decimales.

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("RESTA\n");
Console.ResetColor();

decimal rdecimal1 = 0;
decimal rdecimal2 = 0;

Console.WriteLine("Escriba un numero");
rdecimal1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
rdecimal2 = decimal.Parse(Console.ReadLine());
decimal resultadoresta = rdecimal1 - rdecimal2;
Console.WriteLine($"La resta de los 2 numeros es:" + resultadoresta);
Console.WriteLine("\n");

Console.WriteLine("********************** \n");

//multiplicación de dos números flotantes
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("MULTIPLICACION\n");
Console.ResetColor();


float mfloat1 = 0;
float mfloat2 = 0;
Console.WriteLine("Escriba un numero");
mfloat1 = float.Parse(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
mfloat2 = float.Parse(Console.ReadLine());
float resultadomultiplicacion = mfloat1 * mfloat2;
Console.WriteLine($"La multiplicacion de los 2 numeros es:" + resultadomultiplicacion);
Console.WriteLine("\n");

Console.WriteLine("********************** \n");

//división de dos números enteros
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("DIVISION\n");
Console.ResetColor();

int div1 = 0;
int div2 = 0;

Console.WriteLine("Escriba un numero");
div1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
div2 = int.Parse(Console.ReadLine());
int resultdiv = div1 / div2;
Console.WriteLine($"La division de los 2 numeros es: " + resultdiv);
Console.WriteLine("\n");
Console.WriteLine("********************** \n");

//módulo de dos números enteros.
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("MODULO DE 2 NUMEROS\n");
Console.ResetColor();

int mod1 = 0;
int mod2 = 0;

Console.WriteLine("Escriba un numero");
mod1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
mod2 = int.Parse(Console.ReadLine());
int resultmod = mod1 % mod2;
Console.WriteLine($"El modulo de los 2 numeros es: " + resultmod);
Console.WriteLine("\n");
Console.WriteLine("********************** \n");

///Uso de char y string
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("----USO DE CHAR Y STRING----\n");
Console.ResetColor();

//cadena de texto y la imprima en mayúsculas.
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("IMPRIMIR A MAYUSCULAS\n");
Console.ResetColor();


string cadena1;
Console.WriteLine("Introduzca la cadena de texto\n");
cadena1 = Console.ReadLine();
string cadena_mayusculas = cadena1.ToUpper();
Console.WriteLine($"{cadena_mayusculas}\n");
Console.WriteLine("********************** \n");

// lea una cadena de texto y la imprima en minúsculas.
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("IMPRIMIR A MINUSCULAS\n");
Console.ResetColor();

string cadena2;
Console.WriteLine("Introduzca la cadena de texto\n");
cadena2 = Console.ReadLine();
string cadena_minusculas = cadena2.ToLower();
Console.WriteLine($"{cadena_minusculas}\n");
Console.WriteLine("********************** \n");

//una cadena de texto y la imprima al revés
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("IMPRIMIR AL REVES\n");
Console.ResetColor();

string cadena3;
Console.WriteLine("Introduzca la cadena de texto\n");
cadena3 = Console.ReadLine();
string cadenaalreves = "";
for (int i = cadena3.Length - 1; i >= 0; i--)
{
    cadenaalreves += cadena3[i];
}
Console.WriteLine(cadenaalreves);
Console.WriteLine("\n********************** \n");

//una cadena de texto y busque una palabra en ella.
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("BUSQUEDA DE PALABRA\n");
Console.ResetColor();


Console.WriteLine("Introduce una cadena de texto");
string cadena4 = Console.ReadLine();
Console.WriteLine("Escribe la palabra a buscar");
string palabrabusqueda = Console.ReadLine();
bool encontrado = cadena4.Contains(palabrabusqueda);
if (encontrado)
{
    Console.WriteLine("La Palabra '{0}' se encontro en la cadena", palabrabusqueda);
}
else
{
    Console.WriteLine("La palabra '{0}' no se encontro en la cadena", palabrabusqueda);
}

Console.WriteLine("\n********************** \n");

//una cadena de texto y cuente el número de vocales que contiene
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("CONTEO DE VOCALES\n");
Console.ResetColor();
{
    {
        { 
Console.WriteLine("Introduzca una cadena de texto:");
string cadenaTexto = Console.ReadLine();
int numeroVocales = 0;
for (int i = 0; i < cadenaTexto.Length; i++)
{
    char caracter = Char.ToLower(cadenaTexto[i]);

    if ("aeiouáéíóú".Contains(caracter))
    {
        numeroVocales++;
    }
}

// Mostramos el resultado al usuario
Console.WriteLine("La cadena de texto contiene {0} vocales", numeroVocales);
    }
}
    Console.WriteLine("\n********************** \n");
}

    ///Uso de tipos de datos numéricos

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("----USO DE TIPOS DE DATOS NUMERICOS----\n");
    Console.ResetColor();

    //calcule el área de un triángulo.
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("AREA DE UN TRIANGULO\n");
    Console.ResetColor();


Console.WriteLine("Introduzca la base del triángulo:");
double baseTriangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Introduzca la altura del triángulo:");
double alturaTriangulo = double.Parse(Console.ReadLine());

double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

Console.WriteLine("El área del triángulo es: {0}", areaTriangulo);

Console.WriteLine("\n********************** \n");


    //calcule el volumen de una esfera
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("VOLUMEN DE UNA ESFERA\n");
    Console.ResetColor();

Console.WriteLine("Introduzca el radio de la esfera:");
double radioEsfera = double.Parse(Console.ReadLine());
double volumenEsfera = (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3.0);
Console.WriteLine("El volumen de la esfera es: {0}", volumenEsfera);
Console.WriteLine("\n********************** \n");

    //calcule la distancia entre dos puntos.
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("DISTANCIA ENTRE 2 PUNTOS\n");
    Console.ResetColor();

    double x1 = 0;
    double x2 = 0;
    double y1 = 0;
    double y2 = 0;
    double Distancia = 0;

    Console.WriteLine("Introduce la cordenada de x1");
    x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Introduce la cordenada de x2");
    x2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Introduce la cordenada de y1");
    y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Introduce la cordenada de y2");
    y2 = double.Parse(Console.ReadLine());

    Distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));
    Console.WriteLine("La Distancia ente los dos puntos es de {0} unidades", Distancia);

    Console.WriteLine("\n********************** \n");

    //calcule la temperatura en grados Fahrenheit a partir de la temperatura en grados Celsius.
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("CELSIUS A FAHRENHEIT\n");
    Console.ResetColor();

    double gcelsius = 0;
    double gfahrenheit = 0;

    Console.WriteLine("Escriba los grados celsius");
    gcelsius = double.Parse(Console.ReadLine());
    gfahrenheit = gcelsius * (9 / 5) + 32;
    Console.WriteLine("El total de Grados Fahrenheit es: {0}", gfahrenheit);

    Console.WriteLine("\n********************** \n");

    //calcule la temperatura en grados Celsius a partir de la temperatura en grados Fahrenheit.
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("FAHRENHEIT A CELSIUS\n");
    Console.ResetColor();

    double gcelsius1 = 0;
    double gfahrenheit1 = 0;

    Console.WriteLine("Escrina los grados Fahrenheit");
    gfahrenheit1 = double.Parse(Console.ReadLine());
    gcelsius1 = gfahrenheit1 - 32 / 1.8;
Console.WriteLine("El total de Grados Fahrenheit es: {0}", gcelsius1);

Console.WriteLine("\n********************** \n");



