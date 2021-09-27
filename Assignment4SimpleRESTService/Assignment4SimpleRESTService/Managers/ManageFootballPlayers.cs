using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelLib.Model;

namespace Assignment4SimpleRESTService.Managers
{
    public class ManageFootballPlayers : IManageFootballPlayers
    {
        private static readonly List<FootballPlayer> footballPlayers = new List<FootballPlayer>()
        {
            new FootballPlayer(1, "Christian Eriksen", 100, 23),
            new FootballPlayer(2, "Kasper Dolberg", 150, 10),
            new FootballPlayer(3, "Simon Kjær", 50, 4),
            new FootballPlayer(4, "Mikkel Damsgaard", 125, 7),
            new FootballPlayer(5, "Joakim Mæhle", 80, 5),
            new FootballPlayer(6, "Kasper Schmeichel", 95, 1)
        };

        public IEnumerable<FootballPlayer> Get()
        {
            return new List<FootballPlayer>(footballPlayers);
        }

        public FootballPlayer Get(int id)
        {
            return footballPlayers.Find(f => f.Id == id);
        }

        public bool Create(FootballPlayer newFootballPlayer)
        {
            footballPlayers.Add(newFootballPlayer);
            return true;
        }

        public bool Update(int id, FootballPlayer fbPlayer)
        {
            FootballPlayer footballPlayer = Get(id);
            if (footballPlayer != null)
            {
                footballPlayer.Id = fbPlayer.Id;
                footballPlayer.Name = fbPlayer.Name;
                footballPlayer.Price = fbPlayer.Price;
                footballPlayer.ShirtNumber = fbPlayer.ShirtNumber;

                return true;
            }

            return false;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer footballPlayer = Get(id);
            footballPlayers.Remove(footballPlayer);
            return footballPlayer;
        }
    }
}
