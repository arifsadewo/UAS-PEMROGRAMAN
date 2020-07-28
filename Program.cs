using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_Pemrograman
{
    class Animal  // Class induk
    {
        public virtual void animalSound() //Method yang di override
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // class anak mengambil method dari induk di tandai dengan (:)
    {
        public override void animalSound() //method override
        {
            Console.WriteLine("The pig says: ngikk ngikk..");
        }
    }

    class Dog : Animal  // class anak
    {
        public override void animalSound() //method override
        {
            Console.WriteLine("The dog says: guk guk gukk...");
        }
    }
    class Program
    {
        static void Main(string[] args) //fungsi maind / method main
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myPig.animalSound(); //memanggil method animalSound dalam kelas anak(myPig)
            myDog.animalSound(); //memanggil method animalSound dalam kelas anak(myDog)

            Console.ReadKey(); //untuk menahan agar tidak langsung keluar ketika program di jalankan
        }
    }
}
