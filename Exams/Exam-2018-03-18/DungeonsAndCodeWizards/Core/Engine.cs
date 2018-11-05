using System;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Core
{
    public class Engine
    {
        public void Run()
        {
            DungeonMaster dm = new DungeonMaster();
            string input;

            while (!string.IsNullOrEmpty((input = Console.ReadLine())))
            {
                StringBuilder result = new StringBuilder();
                string[] args = input.Split();
                string command = args[0];
                args = args.Skip(1).ToArray();
                bool gameOver = false;

                try
                {
                    switch (command)
                    {
                        case "JoinParty":
                            Console.WriteLine(dm.JoinParty(args));
                            break;
                        case "AddItemToPool":
                            Console.WriteLine(dm.AddItemToPool(args));
                            break;
                        case "PickUpItem":
                            Console.WriteLine(dm.PickUpItem(args));
                            break;
                        case "UseItem":
                            Console.WriteLine(dm.UseItem(args));
                            break;
                        case "UseItemOn":
                            Console.WriteLine(dm.UseItemOn(args));
                            break;
                        case "GiveCharacterItem":
                            Console.WriteLine(dm.GiveCharacterItem(args));
                            break;
                        case "GetStats":
                            Console.WriteLine(dm.GetStats());
                            break;
                        case "Attack":
                            Console.WriteLine(dm.Attack(args));
                            break;
                        case "Heal":
                            Console.WriteLine(dm.Heal(args));
                            break;
                        case "EndTurn":
                            Console.WriteLine(dm.EndTurn(args));
                            if (dm.IsGameOver())
                            {
                                gameOver = true;
                            }
                            break;
                        case "IsGameOver":
                            Console.WriteLine(dm.IsGameOver());
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine($"Parameter Error: {ae.Message}");
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine($"Invalid Operation: {ioe.Message}");
                }

                if (gameOver)
                {
                    break;
                }
            }

            Console.WriteLine(dm.GameOver());
        }
    }
}
