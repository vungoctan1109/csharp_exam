using System;

namespace Exam2
{
    internal class Program
    {
        public class Animal
        {
            public int weight { get; set; }
            public string name { get; set; }
        

            public void Show()
            {
                Console.WriteLine("Name: {0}, Weight: {1}", name, weight);    
            }

            public void SetMe(int weight, string name)
            {
                this.weight = weight;
                this.name = name;
            }

            public Animal(int weight, string name)
            {
                SetMe(weight, name);
                Show();
            }
        }
        
        public class Lion : Animal
        {
            public Lion(int weight, string name) : base(weight, name)
            {
                
            }
            
        }
        
        public class Tiger : Animal
        {
            public Tiger(int weight, string name) : base(weight, name)
            {
               
            }
        }
        
        public static void Main(string[] args)
        {
            Tiger tiger = new Tiger(100, "tiger");
            Lion lion = new Lion(200, "lion");
        }
    }
}