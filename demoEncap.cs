namespace Demo
{
    public class dencap
    {
        private string ?name;  //{get;set;}
        private int age;  //{get;set;}

        public string Stdntname
        {
            get{
                return name!;
            }

            set{
                name=value;
            }

        }
        public int Stdntage{
            get{
                return age;
            }
            set{
                age=value;
            }
        }
    }
}