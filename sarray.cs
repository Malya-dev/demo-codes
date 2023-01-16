namespace Demo
{
    public class sarray
    {
        public void inptArr()
        {
             System.Console.WriteLine("enter the number of elements:");
                    int size=Convert.ToInt32(Console.ReadLine());
                    int[] arr=new int[size];
                    for(int i=0;i<size;i++){
                        arr[i]=Convert.ToInt32(Console.ReadLine());
                    }
                    System.Console.WriteLine("printing the array after taking input:");
                    for(int i=0;i<size;i++){
                        System.Console.WriteLine(arr[i]);
                    }

                    Array.Sort(arr);
                    foreach(var ttm in arr){
                    System.Console.WriteLine(ttm);
                    }
        }
    }
}