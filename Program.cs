namespace Usercase2AddAt1stLocation
{
    internal class program
    {
        public static void Main()
        {
            UC2AddAt1st list = new UC2AddAt1st();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
           // list.AddAll(23, 56, 78, 34, 56);
            list.InsertAtFirstPosition(1,70);
            list.InsertAtFirstPosition(1,30);
            list.InsertAtFirstPosition(1,56);
            list.Display();
            Console.ReadKey();
        }
    }
}