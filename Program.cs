using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;

// BONUS 1: Para agregar a una persona se necesita su derieccioón, pero para aagregar una dirección se necesita un persona


namespace Lab_10___Pedro_Naretto
{
    class Program
    {
        static void Main(string[] args)
        {

            Assembly modelo = Assembly.LoadFile("C:\\Users\\Pedro\\Desktop\\UAndes\\Progra orientada a objetos\\municipality-library-PedroNaretto\\ClassLibrary1.dll");
            Type[] modTy = modelo.GetTypes();

            //get the PropertyInfo array for all properties

            string sb = "";
            foreach (Type modeloType in modTy)
            {
                PropertyInfo[] properties = modeloType.GetProperties();
                MethodInfo[] methods = modeloType.GetMethods();

                sb += ("================================================================\n");
                sb += (String.Format("Type Name: {0}\n", modeloType.Name));
                if (modeloType.IsClass)
                    sb += "CLASS\n";
                sb += ("================================================================\n");

                //iterate the properties and write output
                foreach (PropertyInfo property in properties)
                {
                    sb += ("----------------------------------------------------------------\n");
                    sb += (String.Format("Property Name: {0}\n", property.Name));
                    sb += ("----------------------------------------------------------------\n");

                    sb += (String.Format("Property Type Name: {0}\n", property.PropertyType.Name));
                    sb += (String.Format("Property Type FullName: {0}\n", property.PropertyType.FullName));

                    sb += (String.Format("Can we read the property?: {0}\n", property.CanRead.ToString()));
                    sb += (String.Format("Can we write the property?: {0}\n", property.CanWrite.ToString()));
                }
                sb += ("******************************\n");
                //iterate the methods and write output
                foreach (MethodInfo method in methods)
                {
                    try
                    {
                        sb += (String.Format("Method info: {0}\n", modeloType.GetMethod(method.Name)));
                        sb += ("***\n");
                    }
                    catch { }
                }
            }

            Console.WriteLine(sb);
            Console.ReadKey();


            Console.WriteLine("Bienvenido a la municipalidad\nQue decea inscribir?\n1)Persona\n2)Propiedad\n3)Automovil\n4)Salir");
            string resultado = Console.ReadLine();
            while (true)
            {
                while (resultado != "1" & resultado != "2" & resultado != "3" & resultado != "4")
                {
                    Console.WriteLine("Comando invalido\nQue decea inscribir?\n1)Persona\n2)Propiedad\n3)Automovil\n4)Salir");
                    resultado = Console.ReadLine();
                }

                if (resultado == "1")
                {
                    int dia;
                    int mes;
                    int año;
                    Console.WriteLine("Ingrese Nombre:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese Apellido:");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese Fecha de nacimiento (en numeros y separados por -):");
                    string[] fecha = Console.ReadLine().Split('-');
                    int.TryParse(fecha[2], out año);
                    int.TryParse(fecha[1], out mes);
                    int.TryParse(fecha[0], out dia);
                    DateTime nacimiento = new DateTime(año, mes, dia);
                    Console.WriteLine("Ingrese Rut:");
                    string rut = Console.ReadLine();
                    ClassLibrary1.Person p = new ClassLibrary1.Person(nombre, apellido, nacimiento, null, rut, null, null);
                }

                if (resultado == "2")
                {
                    int direccion;
                    int año;
                    int piezas;
                    int baños;
                    bool patio;
                    bool piscina;
                    Console.WriteLine("Ingrese calle:");
                    string calle = Console.ReadLine();
                    Console.WriteLine("Ingrese direccion:");
                    int.TryParse(Console.ReadLine(), out direccion);
                    Console.WriteLine("Ingrese comuna:");
                    string comuna = Console.ReadLine();
                    Console.WriteLine("Ingrese ciudad:");
                    string ciudad = Console.ReadLine();
                    Console.WriteLine("Ingrese año de construccion:");
                    int.TryParse(Console.ReadLine(), out año);
                    Console.WriteLine("Ingrese numero de piezas:");
                    int.TryParse(Console.ReadLine(), out piezas);
                    Console.WriteLine("Ingrese numero de baños:");
                    int.TryParse(Console.ReadLine(), out baños);
                    Console.WriteLine("Tiene patio trasero? 1)Si 2)No");
                    string c = Console.ReadLine();
                    if (c != "1" & c != "2")
                    {
                        Console.WriteLine("Comando invalido");
                        Console.WriteLine("Es Dicel? 1)Si 2)No");
                        c = Console.ReadLine();
                    }
                    if (c == "1")
                    { patio = true; }
                    else { patio = false; }
                    Console.WriteLine("Tiene piscina? 1)Si 2)No");
                    c = Console.ReadLine();
                    if (c != "1" & c != "2")
                    {
                        Console.WriteLine("Comando invalido");
                        Console.WriteLine("Es Dicel? 1)Si 2)No");
                        c = Console.ReadLine();
                    }
                    if (c == "1")
                    { piscina = true; }
                    else { piscina = false; }

                    ClassLibrary1.Address a = new ClassLibrary1.Address(calle, direccion, comuna, ciudad, null, año, piezas, baños, patio, piscina);
                }

                if (resultado == "3")
                {
                    int año;
                    int cinturones;
                    bool dicel;
                    Console.WriteLine("Ingrese marca:");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Ingrese Modelo:");
                    string model = Console.ReadLine();
                    Console.WriteLine("Ingrese Año:");
                    int.TryParse(Console.ReadLine(), out año);
                    Console.WriteLine("Ingrese Licencia necesaria:");
                    string licencia = Console.ReadLine();
                    Console.WriteLine("Ingrese numero de cinturones de seguridad:");

                    int.TryParse(Console.ReadLine(), out cinturones);
                    Console.WriteLine("Es Dicel? 1)Si 2)No");
                    string m = Console.ReadLine();
                    if (m != "1" & m != "2")
                    {
                        Console.WriteLine("Comando invalido");
                        Console.WriteLine("Es Dicel? 1)Si 2)No");
                        m = Console.ReadLine();
                    }
                    if (m == "1")
                    { dicel = true; }
                    else { dicel = false; }

                    ClassLibrary1.Car c = new ClassLibrary1.Car(marca, model, año, null, licencia, cinturones, dicel);

                }
                if (resultado == "4")
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
