// See https://aka.ms/new-console-template for more information
string firstName;
string lastName;
string ageAsString;
int age;
Console.Write("What is your first name?");
firstName = Console.ReadLine();
Console.Write("What is your last name?");
lastName = Console.ReadLine();
Console.WriteLine("How old are you?");
ageAsString = Console.ReadLine();
age = Convert.ToInt32(ageAsString);
Console.Write("Hello, " + firstName + " " + 
                          lastName + "! Your initials are " + 
                          firstName[0] + "." + 
                          lastName[0] + "., and you are " + 
                          age + " years old.");