using System;

// Fixed the Compilation Failure of the branch DoubleDispatchWithCompilationErrorDemo

namespace DoubleDynamicDispatchDemo {
    class Program {
        static void Main(string[] args) {
            Animal cat = new Cat();
            Animal dog = new Dog();

            Console.WriteLine("Demonstration of Cat interacting with Dog");
            cat.makesound(dog);

            Console.WriteLine("\nDemonstration of Dog interacting with Cat");
            dog.makesound(cat);

            Console.WriteLine("\nDemonstration of Dog interacting with Dog");
            dog.makesound(dog);

            Console.WriteLine("\nDemonstration of Cat interacting with Cat");
            cat.makesound(cat);
        }
    }

    public abstract class Animal {
        public abstract void makesound();
        public abstract void makesound(Cat cat);
        public abstract void makesound(Dog dog);

        public abstract void makesound(Animal animal);
    }

    public class Cat : Animal {
        public override void makesound() {
            Console.WriteLine("Meow");
        }
        public override void  makesound(Dog dog) {
            Console.WriteLine("Cat reacts to Dog.");           
        }

        public override void makesound(Cat dog) {
            Console.WriteLine("Double Meow");
        }

        public override void makesound(Animal animal) {
            Console.WriteLine("Cat reacts to Animal.");
        }
    }

    public class Dog : Animal {
        public override void makesound() {
            Console.WriteLine("Wuuf");
        }

        public override void makesound(Dog dog) {
            Console.WriteLine("Dog reacts to Cat.");
        }

        public override void makesound(Cat dog) {
            Console.WriteLine("Double Wuuf");
        }

        public override void makesound(Animal animal) {
            Console.WriteLine("Dog reacts to Animal.");
        }
    }
}
