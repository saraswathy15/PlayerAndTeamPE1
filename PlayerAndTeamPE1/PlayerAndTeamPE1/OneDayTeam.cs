using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeamPE1
{
    internal class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }
        public void Add(Player player)
        {
            if (oneDayTeam.Count < oneDayTeam.Capacity)
            {
                oneDayTeam.Add(player);
                Console.WriteLine("Player is added successfully");
            }
            else
            {
                Console.WriteLine("Cannot add ....Team is full!!!!!!");
            }
        }

        public void Remove(int playerId)
        {
            Player playerToRemove = oneDayTeam.Find(player => player.PlayerId == playerId);
            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine("Player is removed successfully");
            }
            else
            {
                Console.WriteLine("Player not found!!!!");
            }
        }
        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.Find(player => player.PlayerId == playerId);
        }
        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.Find(player => player.PlayerName == playerName);
        }
        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}
