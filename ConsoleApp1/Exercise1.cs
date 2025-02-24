using System;
using System.Collections.Generic;

//Opdracht: Maak een for loop waarbij je de naam en leeftijd van de gebruikers in de console schrijft.

public class Exercise1
{
	public Exercise1()
	{
        // lijst van de gebruikers
	    List<User> users = new List<User>();

        //maakt een nieuwe user aan met naam en leeftijd
        users.Add(new User("John", 25));
        users.Add(new User("Jane", 22));

        //Schrijf hier je loop
      
    }


    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

}
