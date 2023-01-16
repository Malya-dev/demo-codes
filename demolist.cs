namespace Demo
{
    public class dlist
    {
        public void show()
        {
            var method=new List<int>(){3,8,8,9,7,7};
            method.Add(69);
            System.Console.WriteLine("printing the list:");
            
            foreach(var print in method){
                System.Console.WriteLine(print);
            }
        }
    }
}