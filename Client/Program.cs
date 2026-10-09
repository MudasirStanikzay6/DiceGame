using DiceGame;

    DiceGame.DiceGame game = new DiceGame.DiceGame();

            Console.WriteLine("========= Dice Game =========");

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Välkommen till tärningsspelet!");

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Tryck Enter för att starta spelet.");    

            Console.WriteLine("--------------------------------");

            Console.WriteLine("Skriv x för att avsluta.");


            string answer = Console.ReadLine()?.ToLower() ?? "";

                if (answer == "x")
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Tack för att du spelade! Hejdå!");
        }   
                else
    {
                game.PlayGame();
}