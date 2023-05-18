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
            // Reads machine data from an Excel file using the DataHandler class
            machines = handler.readExcel();
        }
        // Sorts machines by coordinates
        public List<Machine> SortByCoordinates()
        {
            // Adds machines to the machineRepository

            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }
            // Retrieves machines sorted by coordinates from the machineRepository
            List<Machine> sortedByCoordinates = machineRepository.SortByCoordinates();

            // Displays the sorted machines

            foreach (var machine in sortedByCoordinates)
            {
                Console.WriteLine(machine.ToString());
            }

            return sortedByCoordinates.ToList();
        }
        // Sorts machines by month interval
        public List<Machine> SortByMonth()
        {       
            // Adds machines to the machineRepository

            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }
            // Retrieves machines sorted by month interval from the machineRepository
            List<Machine> sortedByMonth = machineRepository.SortByMonth();

            return sortedByMonth.ToList();
        }

        // Sorts machines by year interval
        public List<Machine> SortByYear()
        {      
            // Adds machines to the machineRepository
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }
            // Retrieves machines sorted by year interval from the machineRepository
            List<Machine> sortedByYear = machineRepository.SortByYear();

            return sortedByYear.ToList();
        }

        public List<Machine> SortByWeek()
        {
            // Sorts machines by week interval
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }
            // Retrieves machines sorted by week interval from the machineRepository

            List<Machine> sortedByWeek = machineRepository.SortByWeek();

            return sortedByWeek.ToList();
        }
        // Sorts machines by lubricant oil type
        public List<Machine> SortByLubricantOils()
        {        
            // Adds machines to the machineRepository
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }
            // Retrieves machines sorted by lubricant oil type from the machineRepository
            List<Machine> sortedByLubricantOils = machineRepository.SortByLubricantOils();

            // Displays the sorted machines
            foreach (var machine in sortedByLubricantOils)
            {
                Console.WriteLine(machine.ToString());
            }

            return sortedByLubricantOils.ToList();
        }
        // Sorts machines by grease type
        public List<Machine> SortByGreases()
        {        
            // Adds machines to the machineRepository
            foreach (var machine in machines)
            {
                machineRepository.AddMachine(machine);
            }
            // Retrieves machines sorted by grease type from the machineRepository
            List<Machine> sortedByGreases = machineRepository.SortByGreases();
            // Displays the sorted machines
            foreach (var machine in sortedByGreases)
            {
                Console.WriteLine(machine.ToString());
            }

            return sortedByGreases.ToList();
        }
        // Displays a menu for interacting with the DataHandler class
        public void ShowDataHandlerMenu(List<Machine> machines)
        {
            Console.WriteLine("LIST_MENU: " +
                              "\nGem liste tryk 1: " +
                              "\nTilbage til hovedmenu tryk 2: ");

            string inputStr = Console.ReadLine();
            int input = int.Parse(inputStr);

            switch (input)
            {
                case 1:
                    handler.SaveList(machines);
                    break;

                case 2:
                    Console.Clear();
                    Menu menu = new Menu();
                    menu.Show();
                    break;
            }


        }
    }
}
