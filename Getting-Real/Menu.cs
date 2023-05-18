using Getting_Real;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Menu
{
    private int input; // Declare an integer variable called 'input'
    private MachineRepository machineRepository = new MachineRepository(); // Create an instance of 'MachineRepository'
    private SortClass sortClass = new SortClass(); // Create an instance of 'SortClass'

    public void Show()
    {
        // Display the menu options to the user
        Console.WriteLine("MENU:" +
                          "\nSorter efter koordinater tryk 1:" +
                          "\nSorter efter uge tryk 2:" +
                          "\nSorter efter måned tryk 3:" +
                          "\nSorter efter år tryk 4:" +
                          "\nSorter efter olie type tryk 5:" +
                          "\nSorter efter fedt type tryk 6:");

        // Read user input from the console
        string inputStr = Console.ReadLine();
        input = int.Parse(inputStr); // Convert the input string to an integer and assign it to 'input'

        // Perform different actions based on the user's input using a switch statement
        switch (input)
        {
            case 1:
                // Sort machines by coordinates and store the result in 'sortedByCoordinates'
                List<Machine> sortedByCoordinates = sortClass.SortByCoordinates();
                Console.WriteLine(sortedByCoordinates.Count); // Display the count of sorted machines
                sortClass.ShowDataHandlerMenu(sortedByCoordinates); // Show the data handling menu for the sorted machines
                break;

            case 2:
                Console.Clear();
                Console.WriteLine("MENU:" +
                                  "\nSorter efter indtastet interval (1, 2, 6, etc.) eller indtast 0 for at vise alle:");
                string inputIntervalWeek = Console.ReadLine();
                // Sort machines by week and store the result in 'sortedByWeek'
                // If the input is '0', sort all machines by week; otherwise, filter by the specified interval
                List<Machine> sortedByWeek = inputIntervalWeek == "0"
                    ? sortClass.SortByWeek()
                    : sortClass.SortByWeek().Where(machine => machine.Interval == inputIntervalWeek).ToList();

                DisplayMachines(sortedByWeek); // Display the sorted machines and their count
                sortClass.ShowDataHandlerMenu(sortedByWeek); // Show the data handling menu for the sorted machines
                break;

            // Similar cases follow for sorting by month, year, lubricant oils, and greases
            // Each case performs sorting, displays sorted machines, counts them, and shows the data handling menu
            case 3:
                Console.Clear();
                Console.WriteLine("MENU:" +
                                  "\nSorter efter indtastet interval (1, 2, 6, etc.) eller indtast 0 for at vise alle:");
                string inputIntervalMonth = Console.ReadLine();
                List<Machine> sortedByMonth = inputIntervalMonth == "0"
                    ? sortClass.SortByMonth()
                    : sortClass.SortByMonth().Where(machine => machine.Interval == inputIntervalMonth).ToList();

                DisplayMachines(sortedByMonth);
                sortClass.ShowDataHandlerMenu(sortedByMonth);
                break;

            case 4:
                Console.Clear();
                Console.WriteLine("MENU:" +
                                  "\nSorter efter indtastet interval (1, 2, 6, etc.) eller indtast 0 for at vise alle:");
                string inputIntervalYear = Console.ReadLine();
                List<Machine> sortedByYear = inputIntervalYear == "0"
                    ? sortClass.SortByYear()
                    : sortClass.SortByYear().Where(machine => machine.Interval == inputIntervalYear).ToList();

                DisplayMachines(sortedByYear);
                sortClass.ShowDataHandlerMenu(sortedByYear);
                break;

            case 5:
                List<Machine> sortedByLubricantOils = sortClass.SortByLubricantOils();
                Console.WriteLine(sortedByLubricantOils.Count);
                sortClass.ShowDataHandlerMenu(sortedByLubricantOils);
                break;

            case 6:
                List<Machine> sortedByGreases = sortClass.SortByGreases();
                Console.WriteLine(sortedByGreases.Count);
                sortClass.ShowDataHandlerMenu(sortedByGreases);
                break;
            default:
                Console.WriteLine("Invalid input"); // Display an error message for invalid input
                break;
        }
    }

    private void DisplayMachines(List<Machine> machines)
    {
        // Display each machine in the sorted list and its count
        foreach (var machine in machines)
        {
            Console.WriteLine(machine.ToString());
        }
        Console.WriteLine(machines.Count);
    }
}


