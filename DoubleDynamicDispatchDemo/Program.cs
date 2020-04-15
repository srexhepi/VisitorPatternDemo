using System;

namespace DoubleDynamicDispatchDemo {
    class Program {
        static void Main(string[] args) {
            Animal cat = new Cat();
            Animal dog = new Dog();

            cat.makesound();
            cat.makesound(dog);
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
        public override void  makesound(Dog dog) {
            Console.WriteLine("Cat reacts to Dog.");           
        }

        public override void makesound(Cat dog) {
            Console.WriteLine("Double Meow");
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
    }
}
