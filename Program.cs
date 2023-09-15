using System;
using IOEx;

namespace CheckHDDSNinXP
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                DriveListEx dd = new DriveListEx();
                dd.Load();
                foreach (var drive in dd)
                {
                    if (drive.SerialNumber.Trim() == "WD-WCC6Y0TPNTK2")
                    {
                        Console.WriteLine("HDD NO Correct - HDD SN Dogru.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }

            Console.WriteLine("HDD SN incorrect - HDD SN Dogru degil.");
            Console.ReadKey();
        }
    }
}