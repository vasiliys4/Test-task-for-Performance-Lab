namespace task1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> listM = new List<int>();
            List<int> CircleArgs = new List<int>();
            List<int> listN = new List<int>();
            int counter = 1;
            int counter2 = 0;
            bool strange = true;
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                listN.Add(i + 1);
            }
            while (strange)
            {
                CircleArgs.AddRange(listN);
                for (int i = counter2; i < counter * m; i++)
                {
                    listM.Add(CircleArgs[i]);
                }
                if (listN[0] == listM[m - 1])
                {
                    list.Add(listM[0]);
                    strange = false;
                }
                else
                {
                    list.Add(listM[0]);
                    listM.Clear();
                }
                counter++;
                counter2 = counter2 + m - 1;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}