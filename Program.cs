namespace Pay_Overtime
{
    public class Program
    {
        float[] work_day = new float[] { 0.0f, 0.0f, 0.0f, 0.0f};
        string[] details = { "Start of Working Day", "End of the Working Day", "Hourly Rate","Overtime Multiplier" };
        static void Main(string[] args)
        {
            Program obj = new Program();    
            obj.Get_Working();
            obj.Calculate_Pay();
        }
        public void Calculate_Pay()
        {
            float earn = 0.00f, extra = 0.00f, actual = 0.00f;

            if (work_day[0] >= 9.00f && work_day[1] <= 17.00f)
            {
                earn = (work_day[1] - work_day[0]) * work_day[2];
            }
            else
            {
                extra = (work_day[1] - 17.00f) * work_day[2] * work_day[3];
                actual = (17.00f - work_day[0]) * work_day[2];
                earn = actual + extra;
            }
            Console.WriteLine($"Your earn that day is - ${earn}");
            
        }
        public void Get_Working()
        {
            Console.WriteLine("Enter the working hours in 24 format");
            for(int i=0; i<details.Length; i++)
            {
                Console.Write($"{details[i]}: ");
                //work_day[i] = float.Parse(Console.ReadLine());
                work_day[i] = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine();
            }

            /*Console.Write("Start of Working day: ");
            work_day[0] = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();

            Console.Write("End of the Working Day: ");
            work_day[1] = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Hourly Rate: ");
            work_day[2] = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Overtime Multiplier: ");
            work_day[3] = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();*/
        }
    }
}