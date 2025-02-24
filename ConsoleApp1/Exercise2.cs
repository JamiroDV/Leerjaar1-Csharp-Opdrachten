using System;
using System.Collections.Generic;

//Opdracht: Maak een for loop waarbij je 10 gebruikers aanmaakt en deze toevoegd aan de lijst.
//als je dit goed heb gedaan zal de console alle toegevoegde name uitschrijven
//de naam mag alles zijn zorg wel dat ze verschillend zijn! Lukt dit niet meteen? probeer dan of je dezelfde naam kan maken.

// Extra uitdaging: Zorg dat in de naam van de gebruiker het getal staat waar hij zich in de lijst bevindt
public class Exercise2
{
	public Exercise2()
	{
        // lijst van de gebruikers
        List<User> users = new List<User>();

        //maakt hier een for loop die de 10 users aanmaakt en deze aan de lijst toevoegd. 


        //hier is de logica van het printen van alle namen van de gebruikers
        foreach (User user in users)
        {
            Console.WriteLine(user.Name);
        }

    }
    internal class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }

}
