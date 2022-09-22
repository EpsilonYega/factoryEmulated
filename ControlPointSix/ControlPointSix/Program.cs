namespace ControlPointSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.CreatePen(50);
            factory.CreatePencil(50);
            factory.ShowCost();
            factory.ShowResouces();
            Console.ReadLine();
        }
    }
}