namespace Demo
{
    public class Darray
    {
        public string darr()
        {
            
            var arr=new string[] {"zeref","naruto","yoyo"}; 
            var joinedNames=string.Join(",",arr);
            //var formatedNames=string.Format("I love {0} but i hate {1} so i do {3}",arr[0],arr[1],arr[2]);
           // return joinedNames;
            return joinedNames;
        }
    }
    
    public enum date{
        day=30,
        month=12,
        year=365
    }
    public class demoarray
    {
        public void print()
        {
            int[] num =new int[] {8,9,64,56,69,96,};
            var len=num.Length;
            System.Console.WriteLine(len);
            System.Console.WriteLine("index of 69:"+ Array.IndexOf(num,69));
            System.Console.WriteLine("the numbers of an array");
            foreach (var n in num){
                System.Console.WriteLine(n);
            }
            Array.Sort(num);
            System.Console.WriteLine("after sorting");
            foreach (var items in num)
            {
                System.Console.WriteLine(items);
                
            }
            Array.Reverse(num);
            System.Console.WriteLine("after reversing");
            foreach(var rev in num){
                System.Console.WriteLine(rev);
            }
        }
    }
    
}