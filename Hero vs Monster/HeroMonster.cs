internal class Program
{
    private static void Main(string[] args)
    {
         int heroLife = 10;
        int monsterLife = 10;
        
        Random dice = new Random();
        
        do {
            int roll = dice.Next(1, 11);
            monsterLife -= roll;
            Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterLife} health.");
            
            if(monsterLife <= 0) continue;
            
            roll = dice.Next(1, 11);
            heroLife -= roll;
            Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroLife} health.");
            
        } while (heroLife > 0 && monsterLife > 0);
        
        Console.WriteLine( heroLife > monsterLife ? "Hero Win" : "Monster Win" );

    }
}