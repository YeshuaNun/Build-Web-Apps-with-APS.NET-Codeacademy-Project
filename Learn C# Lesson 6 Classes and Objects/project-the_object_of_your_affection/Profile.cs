using System;

namespace DatingProfile
{
  class Profile
  {
    private string name;
    private int age;
    private int Age {
        get { return age; }
        set 
        {
            if (value>17)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("You are too young to have an account.");
            }
        }
    }
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;
    
    public Profile(
      string name,
      int age,
      string city = "n/a",
      string country = "n/a",
      string pronouns = "they/them"
    )
    {
      this.name = name;
      this.Age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[0];
    }

    public string ViewProfile()
    {
        string response = $"Name: {this.name}\nAge: {this.age}\nCity: {this.city}\nCountry: {this.country}\nHobbies: ";
        foreach(string hobby in hobbies) {
            response+=$"\n-{hobby}\n";
        }
      return response;
    }

    public void SetHobbies(
        string[] hobbies
    )
    {
        this.hobbies = hobbies;
    }
  }
}