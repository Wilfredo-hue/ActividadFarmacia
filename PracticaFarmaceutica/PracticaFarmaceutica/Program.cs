using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFarmaceutica
{
    class Program
    {


        static void Main(string[] args)
        {
            // Definir medicamentos por enfermedad
            string[] dolorDeCabeza = { "Aspirina", "Ibuprofeno", "Paracetamol" };
            int[] cantidadDolorDeCabeza = { 20, 30, 25 };
            double[] miligramosDolorDeCabeza = { 500, 400, 500 };
            DateTime[] vencimientoDolorDeCabeza = { new DateTime(2024, 6, 30), new DateTime(2023, 12, 31), new DateTime(2022, 9, 30) };

            string[] fiebre = { "Acetaminofén", "Naproxeno", "Diclofenaco" };
            int[] cantidadFiebre = { 25, 30, 20 };
            double[] miligramosFiebre = { 500, 250, 100 };
            DateTime[] vencimientoFiebre = { new DateTime(2023, 12, 31), new DateTime(2022, 9, 30), new DateTime(2024, 6, 30) };

            string[] dolorMuscular = { "Naproxeno", "Ibuprofeno", "Paracetamol" };
            int[] cantidadDolorMuscular = { 30, 20, 25 };
            double[] miligramosDolorMuscular = { 250, 400, 500 };
            DateTime[] vencimientoDolorMuscular = { new DateTime(2022, 9, 30), new DateTime(2024, 6, 30), new DateTime(2023, 12, 31) };

            string[] alergias = { "Loratadina", "Cetirizina", "Difenidramina" };
            int[] cantidadAlergias = { 20, 25, 30 };
            double[] miligramosAlergias = { 10, 10, 50 };
            DateTime[] vencimientoAlergias = { new DateTime(2024, 6, 30), new DateTime(2023, 12, 31), new DateTime(2022, 9, 30) };

            // Pedir al usuario que seleccione una enfermedad
            Console.WriteLine("Seleccione una enfermedad:");
            Console.WriteLine("1. Dolor de cabeza");
            Console.WriteLine("2. Fiebre");
            Console.WriteLine("3. Dolor muscular");
            Console.WriteLine("4. Alergias");
            int seleccion = int.Parse(Console.ReadLine());

            // Mostrar información de medicamentos para la enfermedad seleccionada
            Console.WriteLine("Medicamentos para la enfermedad seleccionada:");
            string[] medicamentos = null;
            int[] cantidades = null;
            double[] miligramos = null;
            DateTime[] vencimientos = null;
            switch (seleccion)

            {
                case 1:
                    medicamentos = dolorDeCabeza;
                    cantidades = cantidadDolorDeCabeza;
                    miligramos = miligramosDolorDeCabeza;
                    vencimientos = vencimientoDolorDeCabeza;
                    break;
                case 2:
                    medicamentos = fiebre;
                    cantidades = cantidadFiebre;
                    miligramos = miligramosFiebre;
                    vencimientos = vencimientoFiebre;
                    break;
                case 3:
                    medicamentos = dolorMuscular;
                    cantidades = cantidadDolorMuscular;
                    miligramos = miligramosDolorMuscular;
                    vencimientos = vencimientoDolorMuscular;
                    break;
                case 4:
                    medicamentos = alergias;
                    cantidades = cantidadAlergias;
                    miligramos = miligramosAlergias;
                    vencimientos = vencimientoAlergias;
                    break;
                default:
                    Console.WriteLine("Selección inválida.");
                    return;
            }
            // Mostrar información de medicamentos para la enfermedad seleccionada
            for (int i = 0; i < medicamentos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {medicamentos[i]}, {cantidades[i]} unidades, {miligramos[i]} mg, vence el {vencimientos[i]:yyyy-MM-dd}");
            }

            // Pedir al usuario que seleccione un medicamento y la cantidad a vender
            Console.WriteLine("Seleccione un medicamento para vender:");
            int seleccionMedicamento = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ha seleccionado: {medicamentos[seleccionMedicamento - 1]}");

            Console.WriteLine("Ingrese la cantidad a vender:");
            int cantidad = int.Parse(Console.ReadLine());

            // Calcular precio total de la venta
            double precio = cantidad * 10.0; // Precio ficticio
            Console.WriteLine($"Precio total: {precio:C}");
            Console.ReadKey();
        }
    }        
}
