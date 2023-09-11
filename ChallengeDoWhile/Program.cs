Random random = new Random();

int heroHealth = 10;
int monsterHealth = 10;

int attack = random.Next(1, 11);

do
{
    monsterHealth -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health.");

    if (monsterHealth > 0)
    {
        heroHealth -= attack;
        Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");
    }
    
} while (heroHealth > 0 && monsterHealth > 0);

if (heroHealth > 0)
{
    Console.WriteLine("Hero wins!");
}
else
{
    Console.WriteLine("Monster wins!");
}

