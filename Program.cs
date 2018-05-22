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

            //Assembly modelo = Assembly.LoadFile("C:\\Users\\ING\\Desktop\\municipality-library-PedroNaretto\\ClassLibrary1.dll");
            //Type[] modTy = modelo.GetTypes();

            ////get the PropertyInfo array for all properties

            //string sb = "";
            //foreach (Type modeloType in modTy)
            //{
            //    PropertyInfo[] properties = modeloType.GetProperties();
            //    MethodInfo[] methods = modeloType.GetMethods();

            //    sb += ("================================================================\n");
            //    sb += (String.Format("Type Name: {0}\n", modeloType.Name));
            //    if (modeloType.IsClass)
            //        sb += "CLASS\n";
            //    sb += ("================================================================\n");

            //    //iterate the properties and write output
            //    foreach (PropertyInfo property in properties)
            //    {
            //        sb += ("----------------------------------------------------------------\n");
            //        sb += (String.Format("Property Name: {0}\n", property.Name));
            //        sb += ("----------------------------------------------------------------\n");

            //        sb += (String.Format("Property Type Name: {0}\n", property.PropertyType.Name));
            //        sb += (String.Format("Property Type FullName: {0}\n", property.PropertyType.FullName));

            //        sb += (String.Format("Can we read the property?: {0}\n", property.CanRead.ToString()));
            //        sb += (String.Format("Can we write the property?: {0}\n", property.CanWrite.ToString()));
            //    }
            //    sb += ("******************************\n");
            //    //iterate the methods and write output
            //    foreach (MethodInfo method in methods)
            //    {
            //        try
            //        {
            //            sb += (String.Format("Method info: {0}\n", modeloType.GetMethod(method.Name)));
            //            sb += ("***\n");
            //        }
            //        catch { }
            //    }
            //}

            //Console.WriteLine(sb);
            



        }
    }
}
