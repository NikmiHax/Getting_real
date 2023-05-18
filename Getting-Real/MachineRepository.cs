namespace Getting_Real;

public class MachineRepository
{
    private List<Machine> machines = new List<Machine>();

    public MachineRepository()
    {
        // Initializes the machines list as an empty list

        machines = new List<Machine>();
    }
    // Adds a machine to the machines list
    public void AddMachine(Machine machine) 
    {
        machines.Add(machine);
    }
    // Sorts the machines list based on the next lubrication date
    public List<Machine> Sort()
    {
        return machines.OrderBy(machine =>
        {
            DateTime nextLubricationDate;

            // Calculates the next lubrication date based on the interval and week/month/year
            if (machine.WeekMonthYear.ToLower() == "uge")
            {
                nextLubricationDate = DateTime.Now.AddDays(int.Parse(machine.Interval) * 7);
            }

            else if (machine.WeekMonthYear.ToLower() == "m")
            {
                nextLubricationDate = DateTime.Now.AddMonths(int.Parse(machine.Interval));
            }

            else if (machine.WeekMonthYear.ToLower() == "år")
            {
                nextLubricationDate = DateTime.Now.AddYears(int.Parse(machine.Interval));
            }

            else if (machine.WeekMonthYear.ToLower() == "timer")
            {
                nextLubricationDate = DateTime.Now.AddHours(int.Parse(machine.Interval));
            }

            else
            {
                throw new ArgumentException("Ugyldig weekmonthyear værdi");
            }
            // Returns the absolute difference in days between the next lubrication date and the current date
            return Math.Abs((nextLubricationDate - DateTime.Now).TotalDays);
        }).ToList();
    }
    // Sorts the machines list by week interval
    public List<Machine> SortByWeek()
    {
        return machines.Where(machine => machine.WeekMonthYear.ToLower() == "uge").OrderBy(machine =>
        {
            // Same logic as the Sort() method for calculating the next lubrication date
            DateTime nextLubricationDate;

            if (machine.WeekMonthYear.ToLower() == "uge")
            {
                nextLubricationDate = DateTime.Now.AddDays(int.Parse(machine.Interval) * 7);
            }

            else
            {
                throw new ArgumentException("Ugyldig weekmonthyear værdi");
            }

            return Math.Abs((nextLubricationDate - DateTime.Now).TotalDays);
        }).ToList();

    }
    // Sorts the machines list by month interval
    public List<Machine> SortByMonth()
    {
        return machines.Where(machine => machine.WeekMonthYear.ToLower() == "m").OrderBy(machine =>
        {
            // Same logic as the Sort() method for calculating the next lubrication date
            DateTime nextLubricationDate;

            if (machine.WeekMonthYear.ToLower() == "m")
            {
                nextLubricationDate = DateTime.Now.AddMonths(int.Parse(machine.Interval));
            }

            else
            {
                throw new ArgumentException("Ugyldig weekmonthyear værdi");
            }

            return Math.Abs((nextLubricationDate - DateTime.Now).TotalDays);
        }).ToList();
    }
    // Sorts the machines list by year interval
    public List<Machine> SortByYear()
    {
        return machines.Where(machine => machine.WeekMonthYear.ToLower() == "år").OrderBy(machine =>
        {
            // Same logic as the Sort() method for calculating the next lubrication date
            DateTime nextLubricationDate;

            if (machine.WeekMonthYear.ToLower() == "år")
            {
                nextLubricationDate = DateTime.Now.AddYears(int.Parse(machine.Interval));
            }

            else
            {
                throw new ArgumentException("Ugyldig weekmonthyear værdi");
            }

            return Math.Abs((nextLubricationDate - DateTime.Now).TotalDays);
        }).ToList();
    }
    // Retrieves the machines' coordinates
    public List<Machine> GetCoordinates()
    {        
        // Modifies the coordinates property of each machine to only include the first 4 characters

        foreach (var machine in machines)
        {
            machine.Coordinates = machine.Coordinates.Substring(0, 4);
        }
        return machines;
    }
    // Sorts the machines list by coordinates
    public List<Machine> SortByCoordinates()
    {
        return machines.OrderBy(machine => machine.Coordinates).ToList();
    }
    // Sorts the machines list by lubrication oil type
    public List<Machine> SortByLubricantOils()
    {
        return machines.OrderBy(machine => machine.LubricationOilType).ToList();
    }
    // Sorts the machines list by grease type
    public List<Machine> SortByGreases()
    {
        return machines.OrderBy(machine => machine.GreaseType).ToList();
    }
}



