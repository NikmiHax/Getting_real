using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Real
{
    public class SortClass
    {
        MachineRepository machineRepository = new MachineRepository();
        DataHandler handler = new DataHandler();
        List<Machine> machines = new List<Machine>();

        public SortClass()
        {
            machines = handler.readExcel();
        }

        public List<Machine> SortByCoordinates()
        {
            // Add machines to the repository
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            // Sort machines by coordinates
            List<Machine> sortedByCoordinates = machineRepository.SortByCoordinates();

            // Display sorted machines
            foreach (var machine in sortedByCoordinates)
            {
                Console.WriteLine(machine.ToString());
            }

            return sortedByCoordinates.ToList();
        }

        public List<Machine> SortByMonth()
        {
            // Add machines to the repository
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            // Sort machines by month
            List<Machine> sortedByMonth = machineRepository.SortByMonth();

            return sortedByMonth.ToList();
        }

        public List<Machine> SortByYear()
        {
            // Add machines to the repository
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            // Sort machines by year
            List<Machine> sortedByYear = machineRepository.SortByYear();

            return sortedByYear.ToList();
        }

        public List<Machine> SortByWeek()
        {
            // Add machines to the repository
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            // Sort machines by week
            List<Machine> sortedByWeek = machineRepository.SortByWeek();

            return sortedByWeek.ToList();
        }

        public List<Machine> SortByLubricantOils()
        {
            // Add machines to the repository
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            // Sort machines by lubricant oils
            List<Machine> sortedByLubricantOils = machineRepository.SortByLubricantOils();

            // Display sorted machines
            foreach (var machine in sortedByLubricantOils)
            {
                Console.WriteLine(machine.ToString());
            }

            return sortedByLubricantOils.ToList();
        }

        public List<Machine> SortByGreases()
        {
            // Add machines to the repository
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }

            // Sort machines by greases
            List<Machine> sortedByGreases = machineRepository.SortByGreases();

            // Display sorted machines
            foreach (var machine in sortedByGreases)
            {
                Console.WriteLine(machine.ToString());
            }

            return sortedByGreases.ToList();
        }

        public void ShowDataHandlerMenu(List<Machine> machines)
        {
            // Display a menu for handling data
            Console.WriteLine("LIST_MENU: " +
                              "\nGem liste tryk 1: " +
                              "\nTilbage til hovedmenu tryk 2: ");

            string inputStr = Console.ReadLine();
            int input = int.Parse(inputStr);

            switch (input)
            {
                case 1:
                    // Save the list of machines
                    handler.SaveList(machines);
                    break;

                case 2:
                    Console.Clear();
                    // Return to the main menu
                    Menu menu = new Menu();
                    menu.Show();
                    break;
            }
        }
    }
}

