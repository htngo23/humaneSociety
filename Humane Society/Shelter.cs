using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humane_Society
{
    class Shelter : IAdd, IMedication
    {
        int money = 200;


        public Dogs sam = new Dogs("Sam", false, false, "Kibble", "Dog", 3);
        public Dogs randy = new Dogs("Randy", false, false, "puppy chow", "Dog", 4);
        public Dogs daisy = new Dogs("Daisy", false, false, "red meats", "Dog", 4);
        public Cats mitsy = new Cats("Mitsy", false, false, "catnip", "Cat", 7);
        public Cats whiskers = new Cats("Whiskers", false, false, "fish", "Cat", 5);

        public Human huy = new Human("Huy", null);
        public Human ralph = new Human("Ralph", null);
        public Human morty = new Human("Morty", null);

        List<Animal> generalCages = new List<Animal>();
        List<Animal> dogCages = new List<Animal>();
        List<Animal> catCages = new List<Animal>();
        List<Animal> ownedAnimals = new List<Animal>();
        List<Human> owners = new List<Human>();

        List<Animal> vaccinatedList = new List<Animal>();

        public void PetWorld()
        {
            add();
            Console.WriteLine("Welcome to pet world");
            Console.WriteLine("Below is our selection of adoptable Animals");
            print();
            Console.ReadLine();
            Console.Clear();
            Menu();
        }
        public Human characterSelector()
        {
            Console.WriteLine("Please select a human: Huy, Ralph, Morty");
            string humanChoice = Console.ReadLine();
            
            if(humanChoice == huy.name)
            {
                Human personChoice = huy;
                return personChoice;
            }
            else if (humanChoice == ralph.name)
            {
                Human personChoice = ralph;
                return personChoice;
            }
            else if (humanChoice == morty.name)
            {
                Human personChoice = morty;
                return personChoice;
            }
            else
            {
                return null;
            }
        }

        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Press 1 for status");
                Console.WriteLine("Press 2 to adopt");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        status(); //use case within a case to check animals of all species
                        break;
                    case "2":
                        adoptPet(characterSelector());
                        break;
                    default:
                        Menu();
                        break;
                }
            }
        }
        public void status()
        {
            Console.Clear();
            Console.WriteLine("To Check All animals input 1");
            Console.WriteLine("To Check dogs input 2");
            Console.WriteLine("To Check cats input 3");
            Console.WriteLine("To check animals who now have homes input 4");
            Console.WriteLine("To check owner statuses input 5");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    foreach (Animal x in generalCages)
                    {
                        Console.WriteLine("Name :" + x.name + ".  Animal Species: " + x.species);
                        if (x.vaccinate == true)
                        {
                            Console.WriteLine(x.name + " has gotten their shots");
                        }
                        else if (x.vaccinate == false)
                        {
                            Console.WriteLine(x.name + " Still needs to get their shots");
                            
                        }
                        Console.WriteLine(x.name + " Prefers to eat " + x.foodPreference + " " + x.hunger + " times a week");
                        Console.WriteLine("\n");
                    }
                    break;

                case "2":
                    foreach (Animal x in dogCages)
                    {
                        Console.WriteLine("Name :" + x.name);
                        if (x.vaccinate == true)
                        {
                            Console.WriteLine(x.name + " has gotten their shots");
                        }
                        else if (x.vaccinate == false)
                        {
                            Console.WriteLine(x.name + " Still needs to get their shots");
                            
                        }
                        Console.WriteLine(x.name + " Prefers to eat " + x.foodPreference + " " + x.hunger + " times a week");
                        Console.WriteLine("\n");
                    }
                    break;
                case "3":
                    foreach (Animal x in catCages)
                    {
                        Console.WriteLine("Name :" + x.name);
                        if (x.vaccinate == true)
                        {
                            Console.WriteLine(x.name + " has gotten their shots");
                        }
                        else if (x.vaccinate == false)
                        {
                            Console.WriteLine(x.name + " Still needs to get their shots");
                            
                        }
                        Console.WriteLine(x.name + " Prefers to eat " + x.foodPreference + " " + x.hunger + " times a week");
                        Console.WriteLine("\n");
                    }
                    break;
                case "4":
                    foreach (Animal x in ownedAnimals)
                    {
                        Console.WriteLine("Name :" + x.name);
                        if (x.vaccinate == true)
                        {
                            Console.WriteLine(x.name + " has gotten their shots");
                        }
                        else if (x.vaccinate == false)
                        {
                            Console.WriteLine(x.name + " Still needs to get their shots");
                            
                        }
                        Console.WriteLine(x.name + " Prefers to eat " + x.foodPreference + " " + x.hunger + " times a week");
                        Console.WriteLine("\n");
                    }
                    break;
                case "5":
                    humanStatus();
                    break;
                default:
                    status();
                    break;
            }

        }

        public void add()
        {

            generalCages.Add(sam);
            generalCages.Add(randy);
            generalCages.Add(daisy);
            generalCages.Add(mitsy);
            generalCages.Add(whiskers);

            dogCages.Add(sam);
            dogCages.Add(randy);
            dogCages.Add(daisy);
            catCages.Add(mitsy);
            catCages.Add(whiskers);

            owners.Add(huy);
            owners.Add(ralph);
            owners.Add(morty);
        }


        //public void chooseAnimal()
        //{

        //    foreach (Animal x in generalCages)
        //    {
        //        Console.WriteLine(x.name);


        //    }
        //    Console.WriteLine("Which animal would you like to move?");
        //    string removeThis = Console.ReadLine();

        //    foreach (Animal x in generalCages)
        //    {
        //        if (removeThis == x.name)

        //        {
        //            if (x.species == "Cat")
        //            {
        //                generalCages.Remove(x);
        //                catCages.Remove(x);
        //                ownedAnimals.Add(x);
        //                Console.WriteLine(x.name + " is now removed from the cages");
        //                break;
        //            }
        //            if(x.species == "Dog")
        //            {
        //                generalCages.Remove(x);
        //                dogCages.Remove(x);
        //                ownedAnimals.Add(x);
        //                Console.WriteLine(x.name + " is now removed from the cages");
        //                break;
        //            }
        //        }
        //    }
        //}

        public void collect()
        {
            money += 100;
            Console.WriteLine("Shelter has collected adoption fee and now has: $" + money);
        }
        public void humanStatus()
        {
            Console.Clear();
            foreach(Human human in owners)
            {
                if(human.animalOwned == null)
                {
                    Console.WriteLine(human.name + " does not yet own any animals");
                }
                else
                {
                    Console.WriteLine(human.name + " Owns " + human.animalOwned.name);
                }
            }
        }

        public void vaccinate(Animal animal)
        {
            bool meds = animal.vaccinate;

            if (meds == true)
            {
                Console.WriteLine("This pet is already vaccinated");
            }
            else if (meds == false)
            {
                animal.vaccinate = true;
                vaccinatedList.Add(animal);
                foreach (Animal x in vaccinatedList)
                {
                    Console.WriteLine(x.name + " is now vaccinated");
                }
            }
        }
        public void adoptPet(Human human)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Selectable animals are:");
            foreach (Animal x in generalCages)
            {
                Console.WriteLine(x.name);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Which animal would you like to Adopt?");
            string adoptee = Console.ReadLine();
            if (adoptee == "Sam")
            {
                human.adopt(sam);
                sam.owned = true;
                generalCages.Remove(sam);
                dogCages.Remove(sam);
                ownedAnimals.Add(sam);
                vaccinate(sam);

            }
            else if (adoptee == "Randy")
            {
                human.adopt(randy);
                randy.owned = true;
                generalCages.Remove(randy);
                dogCages.Remove(randy);
                ownedAnimals.Add(randy);
                vaccinate(randy);
            }
            else if (adoptee == "Daisy")
            {
                human.adopt(daisy);
                daisy.owned = true;
                generalCages.Remove(daisy);
                dogCages.Remove(daisy);
                ownedAnimals.Add(daisy);
                vaccinate(daisy);
            }
            else if (adoptee == "Mitsy")
            {
                human.adopt(mitsy);
                daisy.owned = true;
                generalCages.Remove(mitsy);
                catCages.Remove(mitsy);
                ownedAnimals.Add(mitsy);
                vaccinate(mitsy);
            }
            else if (adoptee == "Whiskers")
            {
                human.adopt(whiskers);
                daisy.owned = true;
                generalCages.Remove(whiskers);
                catCages.Remove(whiskers);
                ownedAnimals.Add(whiskers);
                vaccinate(whiskers);
            }
            collect();
        }

        public void print()
        {
            foreach (Animal x in generalCages)
            {
                Console.WriteLine(x.name);
            }
        }

    }
}












