namespace Getting_Real
{
    public class Machine
    {
        // Properties representing the different attributes of a machine
        public string Interval { get; set; }
        public string WeekMonthYear { get; set; }
        public string FunctionLocation { get; set; }
        public string MachineName { get; set; }
        public string Coordinates { get; set; }
        public string LubricationPoint { get; set; }
        public string LubricationOilType { get; set; }
        public string GreaseType { get; set; }
        public string VolumeLiter { get; set; }
        public string VolumeGrams { get; set; }

        // Constructor to initialize a Machine object with provided values
        public Machine(string interval, string weekMonthYear, string functionLocation, string machineName, string coordinates, string lubricationPoint, string lubricationOilType, string greaseType, string volumeLiter, string volumeGrams)
        {
            Interval = interval;
            WeekMonthYear = weekMonthYear;
            FunctionLocation = functionLocation;
            MachineName = machineName;
            Coordinates = coordinates;
            LubricationPoint = lubricationPoint;
            LubricationOilType = lubricationOilType;
            GreaseType = greaseType;
            VolumeLiter = volumeLiter;
            VolumeGrams = volumeGrams;
        }

        // Override the ToString() method to provide a formatted string representation of the Machine object
        public override string ToString()
        {
            return "Interval: " + Interval + "\nWeekMonthYear: " + WeekMonthYear + "\nFunction Location: " + FunctionLocation + "\nMachine Name: " + MachineName + "\nCoordinates: " + Coordinates
                   + "\nLubrication Point: " + LubricationPoint + "\nLubrication Oil Type: " + LubricationOilType + "\nGrease Oil Type: " + GreaseType + "\nVolume in Liter: " + VolumeLiter + "\nVolume in Grams: " + VolumeGrams + "\n";
        }
    }
