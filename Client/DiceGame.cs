namespace DiceGame;

    public class DiceGame

    {
    public void PlayGame()

    {
        Random random = new Random();

        string answer = "ja";

        while (answer == "ja")
        {
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int sum = dice1 + dice2;

            Console.WriteLine($"Du slog {dice1} och {dice2}. Summan är {sum}.");

            if (sum == 12)
            {
                Console.WriteLine("Grattis 🥳 du har vunnit!");

                break;
            }

            Console.WriteLine("Vill du spela igen? (Ja/Nej)");

            answer = Console.ReadLine()?.ToLower() ?? "nej";
        }
    }
}