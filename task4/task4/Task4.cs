namespace task4
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            task4(file);
        }

        static void task4(string file)
        {
            List<int> number = new List<int>();
            int counter = 0;
            int result = 0;
            
            StreamReader streamReader = new StreamReader(file);
            while (!streamReader.EndOfStream)
            {
                string? StrRead = streamReader.ReadLine();
                int numberperehod = int.Parse(StrRead);
                number.Add(numberperehod);
            }
            for (int i = 0; i < number.Count; i++)
            {
                result += number[i];
            }
            result = result / number.Count;
            for (int i = 0; i < number.Count; i++)
            {
                while (number[i] != result)
                {
                    if (number[i] > result)
                    {
                        number[i]--;
                    }
                    else if (number[i] < result)
                    {
                        number[i]++;
                    }
                    else
                    {
                        break;
                    }
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}