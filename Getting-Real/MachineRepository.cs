namespace Getting_Real;

public class MachineRepository
{
    private List<Machine> machines = new List<Machine>();

    public MachineRepository()
    {
        machines = new List<Machine>();
    }

    public void AddMachine(Machine machine)
    {
        machines.Add(machine);
    }

    public List<Machine> Sort()
    {
        // Sort all machines based on their next lubrication date
        return machines.OrderBy(machine =>
        {
            DateTime nextLubricationDate;

            // Calculate the next lubrication date based on the week/month/year interval
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
                throw new ArgumentException("Ugyldig weekmonthyear værdi"); // Throw an exception for invalid weekmonthyear value
            }

            // Return the absolute difference in days between the next lubrication date and the current date
            return Math.Abs((nextLubricationDate - DateTime.Now).TotalDays);
        }).ToList();
    }

    public List<Machine> SortByWeek()
    {
        // Filter machines with 'WeekMonthYear' equal to "uge" and sort them based on the next lubrication date
        return machines.Where(machine => machine.WeekMonthYear.ToLower() == "uge").OrderBy(machine =>
        {
            DateTime nextLubricationDate;

            // Calculate the next lubrication date based on the week interval
            if (machine.WeekMonthYear.ToLower() == "uge")
            {
                nextLubricationDate = DateTime.Now.AddDays(int.Parse(machine.Interval) * 7);
            }
            else
            {
                throw new ArgumentException("Ugyldig weekmonthyear værdi"); // Throw an exception for invalid weekmonthyear value
            }

            // Return the absolute difference in days between the next lubrication date and the current date
            return Math.Abs((nextLubricationDate - DateTime.Now).TotalDays);
        }).ToList();
    }

    public List<Machine> SortByMonth()
    {
        // Filter machines with 'WeekMonthYear' equal to "m" and sort them based on the next lubrication date
        return machines.Where(machine => machine.WeekMonthYear.ToLower() == "m").OrderBy(machine =>
        {
            DateTime nextLubricationDate;

            // Calculate the next lubrication date based on the month interval
            if (machine.WeekMonthYear.ToLower() == "m")
            {
                nextLubricationDate = DateTime.Now.AddMonths(int.Parse(machine.Interval));
            }
            else
            {
                throw new ArgumentException("Ugyldig weekmonthyear værdi"); // Throw an exception for invalid weekmonthyear value
            }

            // Return the absolute difference in days between the next lubrication date and the current date
            return Math.Abs((nextLubricationDate - DateTime.Now).TotalDays);
        }).ToList();
    }

    public List<Machine> SortByYear()
    {
        // Filter machines with 'WeekMonthYear' equal to "år" and sort them based on the next lubrication date
        return machines.Where(machine => machine.WeekMonthYear.ToLower() == "år").OrderBy(machine =>
        {
            DateTime nextLubricationDate;

            // Calculate the next lubrication date based on the year interval
            if (machine.WeekMonthYear.ToLower() == "år")
            {
                nextLubricationDate = DateTime.Now.AddYears(int.Parse(machine.Interval));
            }
            else
            {
                throw new ArgumentException("Ugyldig weekmonthyear værdi"); // Throw an exception for invalid weekmonthyear value
            }

            // Return the absolute difference in days between the next lubrication date and the current date
            return Math.Abs((nextLubricationDate - DateTime.Now).TotalDays);
        }).ToList();
    }

    public List<Machine> GetCoordinates()
    {
        // Update the coordinates of each machine to include only the first 4 characters
        foreach (var machine in machines)
        {
            machine.Coordinates = machine.Coordinates.Substring(0, 4);
        }

        return machines;
    }

    public List<Machine> SortByCoordinates()
    {
        // Sort machines based on their coordinates in ascending order
        return machines.OrderBy(machine => machine.Coordinates).ToList();
    }

    public List<Machine> SortByLubricantOils()
    {
        // Sort machines based on the lubrication oil type in ascending order
        return machines.OrderBy(machine => machine.LubricationOilType).ToList();
    }

    public List<Machine> SortByGreases()
    {
        // Sort machines based on the grease type in ascending order
        return machines.OrderBy(machine => machine.GreaseType).ToList();
    }
}
