using System.Drawing;


namespace task2
{
    internal class Task2
    {
        static void Main()
        {
            var file1 = Console.ReadLine();
            var file2 = Console.ReadLine();
            decision(file1, file2);
        }

        
        static void decision(string file1, string file2)
        {
            List<float> MidCircle = new List<float>();

            float number;
            float[] MidC = new float[2];
            float Radius = 0;
            float[] Point = new float[2];
            float Result;

            StreamReader sr1 = new StreamReader(file1);

            while (!sr1.EndOfStream)
            {
                string? fstr = sr1.ReadLine();
                string[] tx = fstr.Split(" ");
                for (int i = 0; i < tx.Length; i++)
                {
                    number = float.Parse(tx[i]);
                    MidCircle.Add(number);
                }
            }
            for (int i = 0; i < MidCircle.Count; i++)
            {
                if (i == 0 || i ==1)
                {
                    MidC[i] = MidCircle[i];
                }
                else
                {
                    Radius = MidCircle[2];
                }
            }

            StreamReader sr2 = new StreamReader(file2);

            while (!sr2.EndOfStream)
            {
                string? fstr = sr2.ReadLine();
                string[] tx = fstr.Split(" ");
                for (int i = 0; i < 2; i++)
                {
                    number = float.Parse(tx[i]);
                    Point[i] = number;
                }
                Result = (float)Math.Sqrt((Point[0] - MidC[0]) * (Point[0] - MidC[0]) + (Point[1] - MidC[1]) * (Point[1] - MidC[1]));
                if (Result < Radius)
                {
                    Console.WriteLine("1");
                }
                else if(Result == Radius)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("2");
                }
            }
        }
    }
}