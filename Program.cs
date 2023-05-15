using System;

class Program
{
    static void Main(string[] args)
    {
        // รับค่าจำนวนจริงบวกจากผู้ใช้
        Console.Write("Enter the maximum capacity of the water tank (Vmax): ");
        double Vmax = double.Parse(Console.ReadLine());

        Console.Write("Enter the average volume of water consumed during each break (Vdrink): ");
        double Vdrink = double.Parse(Console.ReadLine());

        Console.Write("Enter the volume of water refilled in each filling round (Vfill): ");
        double Vfill = double.Parse(Console.ReadLine());

        Console.Write("Enter the time interval between breaks (tbreak): ");
        int tbreak = int.Parse(Console.ReadLine());

        Console.Write("Enter the time interval between filling rounds (tfill): ");
        int tfill = int.Parse(Console.ReadLine());

        Console.Write("Enter the total duration of the activity (tday): ");
        int tday = int.Parse(Console.ReadLine());

        // ตรวจสอบเงื่อนไข
        if (Vdrink <= Vmax && tday >= tbreak && tday >= tfill)
        {
            double Vleft = Vmax; // ปริมาตรน้ำที่เหลือในถัง

            // คำนวณปริมาตรน้ำที่เหลือหลังการดื่มน้ำในแต่ละช่วงพัก
            int numBreaks = tday / tbreak;
            double Vconsumed = Vdrink * numBreaks;
            Vleft -= Vconsumed;

            // ตรวจสอบว่ามีน้ำเพียงพอหรือไม่
            if (Vleft >= 0)
            {
                // คำนวณจำนวนรอบที่ต้องเติมน้ำ
                int numFills = tday / tfill;
                double Vfilled = Vfill * numFills;

                // ตรวจสอบว่าถังน้ำมีการเติมเกินหรือไม่
                if (Vfilled > Vmax)
                {
                    Console.WriteLine("Overflow Water");
                }
                else
                {
                    Console.WriteLine("Enough Water, {0} left", Vleft);
                }
            }
            else
            {
                Console.WriteLine("Not Enough Water");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please make sure the conditions are met.");
        }
    }
}
