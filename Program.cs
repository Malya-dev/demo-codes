// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using Demo;

namespace Demo
{
   /* public class person
    {
        public string fname;
        public string lname;
        public int age;
        
        public void Introduce()
        {
            System.Console.WriteLine("my first name is"+ fname+" ");
            System.Console.WriteLine(" my last name is "+lname+" ");
            System.Console.WriteLine("my age is "+age);
        }

        
    }
    class Program
        {
            static void Main(string[] args)
            {   
            int n=Convert.ToInt32(Console.ReadLine());
            for(var i=1;i<n;i++)
            {
                if(i%2==0)
                System.Console.WriteLine(i);
            }
            for(var i=n;i>0;i--)
            {
                if(i%2!=0)
                System.Console.WriteLine(i);
            }

             var name="debmalya";
             var nm=name.ToUpper();
             System.Console.WriteLine(nm);
             
             for(var i=0;i<name.Length;i++)
             {
                System.Console.WriteLine(name[i]);
             }

            int[] arr=new int[2];
            arr[0]=25;
            arr[1]=55;
            System.Console.WriteLine(arr[1]+arr[0]);
            Boolean age=true;
            int realage=(age)? 69:99;
            System.Console.WriteLine(realage);

            var deb= new person();
            deb.fname="Debmalya";
            deb.lname="Samanta";
            deb.age=69;
            deb.Introduce();*/

            //int num=36;
            //float pop=36F;
           /* var n=25;
            var b=52;
            System.Console.WriteLine((float) n / (float) b);
            string v = Console.ReadLine();
            Console.WriteLine("Hello, World!");
            Console.Write("wow yoohoo");
            Console.WriteLine(" My god");
            System.Console.WriteLine(value: v);*/
           // Console.WriteLine(num);

        //    oops cal=new oops();
        //    oops.Calculator();
     
     //abstraction
      /*  abstract class Pop
        {
            public int number;
            public string genre;
            public abstract void music();
            public void listen()
            {
                System.Console.WriteLine("im listening");
            }
        }
            class Song:Pop
            {
                public override void music()
                {
                    System.Console.WriteLine("choose your music");
                }
            }
            class Program
        {
            static void Main(string[] args)
            {
                Song hindi=new Song();
                hindi.music();
                hindi.listen();
                hindi.number=7;
                hindi.genre="sad music";
                System.Console.WriteLine(hindi.number);
                System.Console.WriteLine(hindi.genre);


            }
        }

 // method overloading       

class Program
{
    static int addition(int x, int y)
    {
    return x + y;
    }

    static double addition(double x, double y,double z)
    {
    return x + y + z;
    }

    static void Main(string[] args)
    {
        int myNum1 = addition(8, 5);
        double myNum2 = addition(4.3, 6.26, 7.8);
        Console.WriteLine("Int: " + myNum1);
        Console.WriteLine("Double: " + myNum2);
    }
}*/

//method overrriding

 /*       class Animal
        {
            public virtual void myAnimalSound()
            {
                System.Console.WriteLine("my animal is making sound");
            }  
        }

        class Dog : Animal
            {
                public override void  myAnimalSound()
                {
                    System.Console.WriteLine("DOg is barking");
                }
            }
            class Cat: Animal
            {
                public override void myAnimalSound()
                {
                    System.Console.WriteLine("meaw! mweaw !");
                }
            }
        class Program
        {
            static void Main(string[] args)
            {
                Animal pet=new Animal();
                Dog tommy= new Dog();
                Cat pus= new Cat();

                pet.myAnimalSound();
                tommy.myAnimalSound();
                pus.myAnimalSound();
                
            }

        }   */

//interface

    /*    interface Car
        {
            void newMethod();
        }
        interface Bike
        {
            void method2();
        }
        interface Milage
        {
            public int speed(int s);
        }
        class Democlass:Car,Bike,Milage {
            public void newMethod()
            {
                System.Console.WriteLine("this is the new method");
            }
            public void method2()
            {
                System.Console.WriteLine("this is the second method");
            }
            public int speed(int x){
                int res=x*x;
                return res;
            }
                
            }
    }
        class Program{
            static void Main(string[] args)
            {
                Democlass obj= new Democlass();
                obj.newMethod();
                obj.method2();
                System.Console.WriteLine(obj.speed(9));
            }
        }
*/


         class Program{
            static void Main(string[] args)
            {
               /* Darray sarr= new Darray();
               // System.Console.WriteLine(sarr.darr());

                var method=date.day;
                var method1=12;
                var method2=365;

                System.Console.WriteLine((int)method);
                System.Console.WriteLine((date)method);
                System.Console.WriteLine((date)method1);
                System.Console.WriteLine((int)method2);
               // (date)Enum.parse(typeof(Enum),method2);

               demoarray loops= new demoarray();
               loops.print();  

               sarray n=new sarray();
               n.inptArr();

               dlist doll=new dlist();
               doll.show(); */

                dencap encap=new dencap();
                encap.Stdntname="debmalya";
                encap.Stdntage=7;

                System.Console.WriteLine("name:"+ encap.Stdntname);
                System.Console.WriteLine("age:"+ encap.Stdntage);

                
                oops cal=new oops();
                cal.Calculate();

            }
         }
}

