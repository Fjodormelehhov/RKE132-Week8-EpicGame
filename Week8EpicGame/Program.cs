

string filePath = @"E:\repos";

string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(filePath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(filePath, villainFile));




//string[] heroes = { "Spiderman", "Batman", "Harry potter", "Catwoman" };
//string[] villains = { "Dart Vader", "Dracula", "Joker", "Voldemort", "Sauron" };

string[] weapon = { "pistol", "plastic knife", "maschine gun", "banana", "lasor beam" };


string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
int villainHP = GetCharacterHP(villain);
int villainStrikeStrength = villainHP;
Console.WriteLine($"Today {villain} ({villainHP} HP) with {villainWeapon} tries to take over the world!");

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
int heroHP = GetCharacterHP(hero);
int heroStrikeStrength = heroHP;
Console.WriteLine($"But {hero} ({heroHP} HP) with {heroWeapon} saves the day.");

while (heroHP > 0 && villainHP > 0)
{
    heroHP = heroHP - Hit(villain, villainStrikeStrength);
    villainHP = villainHP - Hit(hero, heroStrikeStrength);
}
Console.WriteLine($"Hero {hero} HP: {heroHP}");
Console.WriteLine($"Villain {villain} HP: {villainHP}");

if (heroHP > 0)
{
    Console.WriteLine($"{hero} saved the day!");
}
else if (villainHP > 0)
{
    Console.WriteLine("Dark side wins!");
}
else
{
    Console.WriteLine("Draw!");
}

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}

static int GetCharacterHP(string characterName)
{
    if (characterName.Length < 10)
    {
        return 10;
    }
    else
    {
        return characterName.Length;
    }
}


static int Hit(string characterName, int characterHP)
{
    Random rnd = new Random();

    int strike = rnd.Next(0, characterHP);

    if (strike == 0)
    {
        Console.WriteLine($"{characterName} missed the target!");
    }
    else if (strike == characterHP - 1)
    {
        Console.WriteLine($"{characterName} made a critical hit!");
    }
    else
    {
        Console.WriteLine($"{characterName} hit {strike}!");
    }

    return strike;

}




//namespace DataFromFile
//{
//class Program
// {
// static void Main(string[] args)
//{
//  string filePath = @""E:\repos\heroes.txt"";
//string[] dataFromFile = File.ReadAllLines(filePath);
//foreach (string heroes in dataFromFile)
//{
//               Console.WriteLine(heroes);
//         }
//   }
// }
//}