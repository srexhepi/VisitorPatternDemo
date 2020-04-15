using System;

// Demonstation on Single Dynamic Dispatch

namespace DoubleDynamicDispatchDemo {
    class Program {
        static void Main(string[] args) {
            Animal cat = new Cat();
            Animal dog = new Dog();

            cat.makesound();
            dog.makesound();
        }
    }

    public abstract class Animal {
        public abstract void makesound();
        public abstract void makesound(Cat cat);
        public abstract void makesound(Dog dog);
    }

    public class Cat : Animal {
        public override void makesound() {
            Console.WriteLine("Meow");
        }
    }

    public class Dog : Animal {
        public override void makesound() {
            Console.WriteLine("Wuuf");
        }
}
