namespace MS_Learning_Paths.AddingLogic
{
    internal class Loops
    {

        /*
         Add looping logic to your code using the do-while and while statements in C#

           Game Rules

       The hero and the monster will start with 10 health points.
       All attacks will be a value between 1 and 10.
       The hero will attack first.
       Print the amount of health the monster lost and their remaining health.
       If the monster's health is greater than 0, it can attack the hero.
       Print the amount of health the hero lost and their remaining health.
       Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
       Print the winner.


           Desired output:
           Monster was damaged and lost 1 health and now has 9 health.
           Hero was damaged and lost 1 health and now has 9 health.
           Monster was damaged and lost 7 health and now has 2 health.
           Hero was damaged and lost 6 health and now has 3 health.
           Monster was damaged and lost 9 health and now has -7 health.
           Hero wins!
         */

        Random random = new Random();

        int heroHealth = 10;
        int monsterHealth = 10;
        int attackValue;

        public void voidPlayGame()
        {
            while ((monsterHealth > 0) && (heroHealth > 0))
            {
                attackValue = random.Next(1, 11);
                monsterHealth -= attackValue;

                Console.WriteLine($"Monster lost {attackValue} health. \n" +
                    $"Remaining health = {monsterHealth}");

                if (monsterHealth <= 0)
                {
                    Console.WriteLine("Hero wins!");
                    break;
                }

                attackValue = random.Next(1, 11);
                heroHealth -= attackValue;

                Console.WriteLine($"Hero lost {attackValue} health. \n" +
                    $"Remaining health = {heroHealth}");

                if (heroHealth <= 0)
                {
                    Console.WriteLine("Monster wins!");
                    break;
                }

            }
        }
    }
}
