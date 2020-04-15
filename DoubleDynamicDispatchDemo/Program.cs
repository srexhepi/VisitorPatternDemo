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
}
