using System;

namespace Polymorfism
{
    // =========== FRÅGOR NEDAN ===========
    // 13. F: Om samtliga fåglar behöver en ny attribut bör det läggas till i klassen Bird
    // 14. F: Ska alla djur få en ny attribut bör man lägga till the i klassen Animal
    internal abstract class Animal
    {
        public string Name;
        public int Age;
        public double Weight;

        public abstract void DoSound();

        public virtual void Do(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public virtual string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}";
        }
    }

    internal class Horse : Animal
    {
        public double Height;
        public void Do(string name, int age, double weight, double height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }
        public override void DoSound()
        {
            Console.WriteLine("Neigh");
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Height: {Height}";
        }
    }

    internal class Dog : Animal
    {
        public string Kindness;
        public void Do(string name, int age, double weight, string kindness)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Kindness = kindness;
        }
        public override void DoSound()
        {
            Console.WriteLine("Woof");
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Height: {Kindness}";
        }

        public string ReturnString()
        {
            return "String is returned";
        }
    }

    internal class Hedgehog : Animal
    {
        public int NrOfSpikes;
        public void Do(string name, int age, double weight, int nrOfSpikes)
        {
            Name = name;
            Age = age;
            Weight = weight;
            NrOfSpikes = nrOfSpikes;
        }
        public override void DoSound()
        {
            Console.WriteLine("I am a hedgehog");
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Height: {NrOfSpikes}";
        }
    }

    internal class Worm : Animal
    {
        public string IsPoisonous;
        public void Do(string name, int age, double weight, string isPoisonous)
        {
            Name = name;
            Age = age;
            Weight = weight;
            IsPoisonous = isPoisonous;
        }
        public override void DoSound()
        {
            Console.WriteLine("*Weird worm noises*");
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Height: {IsPoisonous}";
        }
    }

    internal class Bird : Animal
    {
        public int WingSpan;
        public void Do(string name, int age, double weight, int wingSpan)
        {
            Name = name;
            Age = age;
            Weight = weight;
            WingSpan = wingSpan;
        }
        public override void DoSound()
        {
            Console.WriteLine("Chirp chirp");
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Height: {WingSpan}";
        }
    }

    internal class Wolf : Animal
    {
        public int PackSize;
        public void Do(string name, int age, double weight, int packSize)
        {
            Name = name;
            Age = age;
            Weight = weight;
            PackSize = packSize;
        }
        public override void DoSound()
        {
            Console.WriteLine("Wooooo");
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Height: {PackSize}";
        }
    }

    internal class Pelican : Bird
    {
        public int BeakSize;
        public void Do(string name, int age, double weight, int wingSpan, int beakSize)
        {
            Name = name;
            Age = age;
            Weight = weight;
            WingSpan = wingSpan;
            BeakSize = beakSize;
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Height: {WingSpan}, Beak size: {BeakSize}";
        }
    }

    internal class Flamingo : Bird
    {
        public int LegSize;
        public void Do(string name, int age, double weight, int wingSpan, int legSize)
        {
            Name = name;
            Age = age;
            Weight = weight;
            WingSpan = wingSpan;
            LegSize = legSize;
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Height: {WingSpan}, Leg size: {LegSize}";
        }
    }

    internal class Swan : Bird
    {
        public int BeautyScore;
        public void Do(string name, int age, double weight, int wingSpan, int beautyScore)
        {
            Name = name;
            Age = age;
            Weight = weight;
            WingSpan = wingSpan;
            BeautyScore = beautyScore;
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Height: {WingSpan}, Beauty Score: {BeautyScore}";
        }
    }

    internal interface IPerson
    {
        void Talk();
    }

    internal class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("Hello, I am Wolfman.");
        }

        public override string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}, Height: {PackSize}";
        }
    }
}