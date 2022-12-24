namespace Lab6_Misyuro.Kirill_Workers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPosition> workers = new List<IPosition>();
            workers.Add(new Director());
            workers.Add(new Accountant());
            workers.Add(new Worker());
            foreach (IPosition w in workers)
            {
                Console.WriteLine(w.GetPosition());
            }
        }
    }
}