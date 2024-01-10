using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeamPE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam odTeam = new OneDayTeam();

            string Cont;

            try
            {
                do
                {
                    Console.WriteLine("Enter1: To Add Player \t2: To Remove Player by Id\t3: Get Player By Id\t4: Get Player by Name\t5: Get All Players");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Player player = new Player();
                            Console.Write("Enter Player Id:");
                            player.PlayerId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Player Name:");
                            player.PlayerName = Console.ReadLine();
                            Console.Write("Enter Player Age:");
                            player.PlayerAge = int.Parse(Console.ReadLine());

                            odTeam.Add(player);
                            break;
                        case 2:
                            Console.Write("Enter Player Id to Remove:");
                            int playerId = int.Parse(Console.ReadLine());
                            odTeam.Remove(playerId);
                            break;
                        case 3:
                            Console.Write("Enter Player Id to get:");
                            playerId = int.Parse(Console.ReadLine());
                            Player retrievedPlayer = odTeam.GetPlayerById(playerId);
                            if (retrievedPlayer != null)
                            {
                                Console.WriteLine($"Player Id: {retrievedPlayer.PlayerId}, Name: {retrievedPlayer.PlayerName}, Age: {retrievedPlayer.PlayerAge}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found.");
                            }
                            break;
                        case 4:
                            Console.Write("Enter Player Name to get:");
                            string playerName = Console.ReadLine();
                            retrievedPlayer = odTeam.GetPlayerByName(playerName);
                            if (retrievedPlayer != null)
                            {
                                Console.WriteLine($"Player Id: {retrievedPlayer.PlayerId}, Name: {retrievedPlayer.PlayerName}, Age: {retrievedPlayer.PlayerAge}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found.");
                            }
                            break;
                        case 5:
                            List<Player> players = odTeam.GetAllPlayers();
                            foreach (Player p in players)
                            {
                                Console.WriteLine($"Player Id: {p.PlayerId}, Name: {p.PlayerName}, Age: {p.PlayerAge}");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    Console.Write("Do you want to continue (yes/no)?:");
                    Cont = Console.ReadLine().ToLower();

                    if (Cont == "no")
                    {
                        return;
                    }

                } while (Cont == "yes");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error!!!!! " + ex.Message);

            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
