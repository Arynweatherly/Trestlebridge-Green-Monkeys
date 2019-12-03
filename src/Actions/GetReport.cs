// using System;
// using System.Collections.Generic;
// using System.Linq;
// using Trestlebridge;
// using Trestlebridge.Interfaces;
// using Trestlebridge.Models;
// using Trestlebridge.Models.Facilities;

// namespace Trestlebridge.Actions
// {
//     public class Report
//     {
//         public void GetReport(GrazingField farm)
//         {

//             Console.WriteLine("1. Grazing Fields");
//             Console.WriteLine("2. Chicken Houses ");
//             Console.WriteLine("3. Duck Houses");
//             Console.WriteLine("4. Exit");
//             Console.WriteLine();
//             var option = Console.ReadLine();

// if (option == "1")
// {

//     var number = 1;
//     foreach (var field in farm.GrazingFields)
//     {
//         Console.WriteLine($"{number ++} {field.Capacity} ")

//     }

// }

//     else if (option == "2")
//     {
//         DisplayBanner();
//         PurchaseStock.CollectInput(Trestlebridge);
//     }
//     else if (option == "4")
//     {
//         DisplayBanner();
//         Report.GetReport();
//         Console.WriteLine();
//         Console.WriteLine("\n\n\n");
//         Console.WriteLine("Press return key to go back to main menu.");
//         Console.ReadLine();
//     }
//     else if (option == "5")
//     {
//         Console.WriteLine("Today is a great day for farming");
//         break;
//     }
//     else
//     {
//         Console.WriteLine($"Invalid option: {option}");
//     }
//          }

//         public void GetGrazingFields()
//         {
//             var number = 1;
//             foreach (var field in farm.GrazingFields)
//             {
//                 Console.WriteLine($"{number ++} {field.Capacity} ")
//             }
//         }

//     }
