namespace UserCase3AddAtEnd
{
    internal class program
    {
        public static void Main()
        {
            UC3AddAtEnd List = new UC3AddAtEnd();
            List.AddAtEnd(56);
            List.AddAtEnd(30);
            List.AddAtEnd(70);
            List.Display();
            Console.ReadKey();
        }
    }
}