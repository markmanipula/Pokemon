using System;

namespace Pokemon
{
    class Program
    {


        static void Main()
        {
            Console.WriteLine("Welcome to Pokemon! Please choose a Pokemon");
            Console.WriteLine("(1) Bulbasaur");
            Console.WriteLine("(2) Charmander");
            Console.WriteLine("(3) Squirtle");
            Console.WriteLine("(4) Pikachu");

            Random random = new Random();


            int UserPokemonNumber = int.Parse(Console.ReadLine());
            int computerPokemonNumber = random.Next(1, 5);

            while (UserPokemonNumber == computerPokemonNumber)
            {
                computerPokemonNumber = random.Next(1, 5);
            }

            if ((UserPokemonNumber == 1 && computerPokemonNumber == 2)) Console.WriteLine("Bulbasaur VS Charmander");
            if ((UserPokemonNumber == 1 && computerPokemonNumber == 3)) Console.WriteLine("Bulbasaur VS Squirtle");
            if ((UserPokemonNumber == 1 && computerPokemonNumber == 4)) Console.WriteLine("Bulbasaur VS Pikachu");
            if ((UserPokemonNumber == 2 && computerPokemonNumber == 1)) Console.WriteLine("Charmander VS Bulbasaur");
            if ((UserPokemonNumber == 2 && computerPokemonNumber == 3)) Console.WriteLine("Charmander VS Squirtle");
            if ((UserPokemonNumber == 2 && computerPokemonNumber == 4)) Console.WriteLine("Charmander VS Pikachu");
            if ((UserPokemonNumber == 3 && computerPokemonNumber == 1)) Console.WriteLine("Squirtle VS Bulbasaur");
            if ((UserPokemonNumber == 3 && computerPokemonNumber == 2)) Console.WriteLine("Squirtle VS Charmander");
            if ((UserPokemonNumber == 3 && computerPokemonNumber == 4)) Console.WriteLine("Squirtle VS Pikachu");
            if ((UserPokemonNumber == 4 && computerPokemonNumber == 1)) Console.WriteLine("Pikachu VS Bulbasaur");
            if ((UserPokemonNumber == 4 && computerPokemonNumber == 2)) Console.WriteLine("Pikachu VS Charmander");
            if ((UserPokemonNumber == 4 && computerPokemonNumber == 3)) Console.WriteLine("Pikachu VS Squirtle");


            int userHealth = 100;
            int computerHealth = 100;

            int tackleDamage, vineWhipDamage, tailWhipDamage, emberDamage, headbuttDamage, watergunDamage,
                thundershockDamage, quickAttackDamage;

            tackleDamage = vineWhipDamage = tailWhipDamage = emberDamage = headbuttDamage = watergunDamage =
                thundershockDamage = quickAttackDamage = 20;


            while (computerHealth >= 0 && userHealth >= 0)
            {
                //Bulbasaur VS Charmander
                if ((UserPokemonNumber == 1 && computerPokemonNumber == 2))
                {
                    Console.WriteLine("(1)Tackle (2)Vine Whip");
                    int userAttack = int.Parse(Console.ReadLine());
                    if (userAttack == 1)
                    {
                        Console.WriteLine("Bulbasaur used tackle");
                        computerHealth -= tackleDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (userAttack == 2)
                    {
                        Console.WriteLine("Bulbasaur used Vine Whip");
                        computerHealth -= vineWhipDamage / 2;
                        Console.WriteLine("It's not very effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }

                    int computerAttack = random.Next(1, 3);

                    if (computerAttack == 1)
                    {
                        Console.WriteLine("Charmander used tail whip");
                        userHealth -= tailWhipDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (computerAttack == 2)
                    {
                        Console.WriteLine("Charmander used ember");
                        userHealth -= emberDamage * 2;
                        Console.WriteLine("It's super effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                }

                //Bulbasaur VS Squirle
                if ((UserPokemonNumber == 1 && computerPokemonNumber == 3))
                {
                    Console.WriteLine("(1)Tackle (2)Vine Whip");
                    int userAttack = int.Parse(Console.ReadLine());
                    if (userAttack == 1)
                    {
                        Console.WriteLine("Bulbasaur used tackle");
                        computerHealth -= tackleDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (userAttack == 2)
                    {
                        Console.WriteLine("Bulbasaur used Vine Whip");
                        computerHealth -= vineWhipDamage * 2;
                        Console.WriteLine("It's super effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }

                    int computerAttack = random.Next(1, 3);

                    if (computerAttack == 1)
                    {
                        Console.WriteLine("Squirtle used headbutt");
                        userHealth -= headbuttDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (computerAttack == 2)
                    {
                        Console.WriteLine("Squirtle used water gun");
                        userHealth -= watergunDamage / 2;
                        Console.WriteLine("It's not very effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                }

                //Bulbasaur VS Pikachu
                if ((UserPokemonNumber == 1 && computerPokemonNumber == 4))
                {
                    Console.WriteLine("(1)Tackle (2)Vine Whip");
                    int userAttack = int.Parse(Console.ReadLine());
                    if (userAttack == 1)
                    {
                        Console.WriteLine("Bulbasaur used tackle");
                        computerHealth -= tackleDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (userAttack == 2)
                    {
                    Console.WriteLine("Bulbasaur used Vine Whip");
                    computerHealth -= vineWhipDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }

                    int computerAttack = random.Next(1, 3);

                    if (computerAttack == 1)
                    {
                        Console.WriteLine("Pikachu used quick attack");
                        userHealth -= quickAttackDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (computerAttack == 2)
                    {
                        Console.WriteLine("Pikachu used thundershock");
                        userHealth -= thundershockDamage / 2;
                        Console.WriteLine("It's not very effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }                    
                }

                //Charmander VS Bulbasaur
                if ((UserPokemonNumber == 2 && computerPokemonNumber == 1))
                {
                    Console.WriteLine("(1)Tail whip (2)ember");
                    int userAttack = int.Parse(Console.ReadLine());
                    if (userAttack == 1)
                    {
                        Console.WriteLine("Charmander used tail whip");
                        computerHealth -= tailWhipDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (userAttack == 2)
                    {
                        Console.WriteLine("Charmander used ember");
                        computerHealth -= emberDamage * 2;
                        Console.WriteLine("It's super effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }

                    int computerAttack = random.Next(1, 3);

                    if (computerAttack == 1)
                    {
                        Console.WriteLine("Bulbasaur used tackle");
                        userHealth -= tackleDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (computerAttack == 2)
                    {
                        Console.WriteLine("Bulbasaur used vine whip");
                        userHealth -= vineWhipDamage / 2;
                        Console.WriteLine("It's not very effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                }

                //Charmander VS Squirtle
                if ((UserPokemonNumber == 2 && computerPokemonNumber == 3))
                {
                    Console.WriteLine("(1)Tail whip (2)ember");
                    int userAttack = int.Parse(Console.ReadLine());
                    if (userAttack == 1)
                    {
                        Console.WriteLine("Charmander used tail whip");
                        computerHealth -= tailWhipDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (userAttack == 2)
                    {
                        Console.WriteLine("Charmander used ember");
                        computerHealth -= emberDamage / 2;
                        Console.WriteLine("It's not very effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }

                    int computerAttack = random.Next(1, 3);

                    if (computerAttack == 1)
                    {
                        Console.WriteLine("Squirtle used headbutt");
                        userHealth -= headbuttDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (computerAttack == 2)
                    {
                        Console.WriteLine("Squirtle used water gun");
                        userHealth -= watergunDamage * 2;
                        Console.WriteLine("It's super effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                }

                //Charmander VS Pikachu
                if ((UserPokemonNumber == 2 && computerPokemonNumber == 4))
                {
                    Console.WriteLine("(1)Tail whip (2)ember");
                    int userAttack = int.Parse(Console.ReadLine());
                    if (userAttack == 1)
                    {
                        Console.WriteLine("Charmander used tail whip");
                        computerHealth -= tailWhipDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (userAttack == 2)
                    {
                        Console.WriteLine("Charmander used ember");
                        computerHealth -= emberDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }

                    int computerAttack = random.Next(1, 3);

                    if (computerAttack == 1)
                    {
                        Console.WriteLine("Pikachu used quick attack");
                        userHealth -= quickAttackDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (computerAttack == 2)
                    {
                        Console.WriteLine("Pikachu used thundershock");
                        userHealth -= thundershockDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                }

                //Squirtle VS Bulbasaur
                if ((UserPokemonNumber == 3 && computerPokemonNumber == 1))
                {
                    Console.WriteLine("(1)headbutt (2)water gun");
                    int userAttack = int.Parse(Console.ReadLine());
                    if (userAttack == 1)
                    {
                        Console.WriteLine("Squirtle used headbutt");
                        computerHealth -= headbuttDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (userAttack == 2)
                    {
                        Console.WriteLine("Squirtle used water gun");
                        computerHealth -= watergunDamage / 2;
                        Console.WriteLine("It's not effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }

                    int computerAttack = random.Next(1, 3);

                    if (computerAttack == 1)
                    {
                        Console.WriteLine("Bulbasaur used tackle");
                        userHealth -= tackleDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (computerAttack == 2)
                    {
                        Console.WriteLine("Bulbasaur used vine whip");
                        userHealth -= vineWhipDamage * 2;
                        Console.WriteLine("It's super effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                }

                //Squirtle VS Charmander
                if ((UserPokemonNumber == 3 && computerPokemonNumber == 2))
                {
                    Console.WriteLine("(1)headbutt (2)water gun");
                    int userAttack = int.Parse(Console.ReadLine());
                    if (userAttack == 1)
                    {
                        Console.WriteLine("Squirtle used headbutt");
                        computerHealth -= headbuttDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (userAttack == 2)
                    {
                        Console.WriteLine("Squirtle used water gun");
                        computerHealth -= watergunDamage * 2;
                        Console.WriteLine("It's nsuper effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }

                    int computerAttack = random.Next(1, 3);

                    if (computerAttack == 1)
                    {
                        Console.WriteLine("Charmander used tail whip");
                        userHealth -= tailWhipDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (computerAttack == 2)
                    {
                        Console.WriteLine("Charmander used ember");
                        userHealth -= emberDamage / 2;
                        Console.WriteLine("It's not effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                }

                //Squirtle vs Pikachu
                if ((UserPokemonNumber == 3 && computerPokemonNumber == 4))
                {
                    Console.WriteLine("(1)headbutt (2)water gun");
                    int userAttack = int.Parse(Console.ReadLine());
                    if (userAttack == 1)
                    {
                        Console.WriteLine("Squirtle used headbutt");
                        computerHealth -= headbuttDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (userAttack == 2)
                    {
                        Console.WriteLine("Squirtle used water gun");
                        computerHealth -= watergunDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }

                    int computerAttack = random.Next(1, 3);

                    if (computerAttack == 1)
                    {
                        Console.WriteLine("Pikachu used quick attack");
                        userHealth -= quickAttackDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (computerAttack == 2)
                    {
                        Console.WriteLine("Pikachu used thundershock");
                        userHealth -= thundershockDamage * 2;
                        Console.WriteLine("It's super effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                }

                //Pikachu VS Bulbasaur
                if ((UserPokemonNumber == 4 && computerPokemonNumber == 1))
                {
                    Console.WriteLine("(1)Quick attack (2)thundershock");
                    int userAttack = int.Parse(Console.ReadLine());
                    if (userAttack == 1)
                    {
                        Console.WriteLine("Pikachu used quick attack");
                        computerHealth -= quickAttackDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (userAttack == 2)
                    {
                        Console.WriteLine("Pikachu used thundershock");
                        computerHealth -= thundershockDamage / 2;
                        Console.WriteLine("It's not effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }

                    int computerAttack = random.Next(1, 3);

                    if (computerAttack == 1)
                    {
                        Console.WriteLine("Bulbasaur used tackle");
                        userHealth -= tackleDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (computerAttack == 2)
                    {
                        Console.WriteLine("Bulbasaur used vine whip");
                        userHealth -= vineWhipDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                }

                //Pikachu VS Charmander
                if ((UserPokemonNumber == 4 && computerPokemonNumber == 2))
                {
                    Console.WriteLine("(1)Quick attack (2)thundershock");
                    int userAttack = int.Parse(Console.ReadLine());
                    if (userAttack == 1)
                    {
                        Console.WriteLine("Pikachu used quick attack");
                        computerHealth -= quickAttackDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (userAttack == 2)
                    {
                        Console.WriteLine("Pikachu used thundershock");
                        computerHealth -= thundershockDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }

                    int computerAttack = random.Next(1, 3);

                    if (computerAttack == 1)
                    {
                        Console.WriteLine("Charmander used tail whip");
                        userHealth -= tailWhipDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (computerAttack == 2)
                    {
                        Console.WriteLine("Charmander used ember");
                        userHealth -= emberDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                }

                //Pikachu VS Squirtle
                if ((UserPokemonNumber == 4 && computerPokemonNumber == 3))
                {
                    Console.WriteLine("(1)Quick attack (2)thundershock");
                    int userAttack = int.Parse(Console.ReadLine());
                    if (userAttack == 1)
                    {
                        Console.WriteLine("Pikachu used quick attack");
                        computerHealth -= quickAttackDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (userAttack == 2)
                    {
                        Console.WriteLine("Pikachu used thundershock");
                        computerHealth -= thundershockDamage * 2;
                        Console.WriteLine("It's super effective");
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }

                    int computerAttack = random.Next(1, 3);

                    if (computerAttack == 1)
                    {
                        Console.WriteLine("Squirtle used headbutt");
                        userHealth -= headbuttDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                    if (computerAttack == 2)
                    {
                        Console.WriteLine("Squirtle used water gun");
                        userHealth -= watergunDamage;
                        Console.WriteLine("Your remaining health is " + userHealth);
                        Console.WriteLine("Enemy remaining health is " + computerHealth);
                    }
                }
            }

            if (userHealth > computerHealth) Console.WriteLine("Congratulations, you won!");
            else Console.WriteLine("Better luck next time!");

        }
    }
}
