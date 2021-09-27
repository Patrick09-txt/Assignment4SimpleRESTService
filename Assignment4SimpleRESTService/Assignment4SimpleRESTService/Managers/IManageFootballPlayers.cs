using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelLib.Model;

namespace Assignment4SimpleRESTService.Managers
{
    interface IManageFootballPlayers
    {
        IEnumerable<FootballPlayer> Get();
        FootballPlayer Get(int id);
        bool Create(FootballPlayer value);
        bool Update(int id, FootballPlayer value);
        FootballPlayer Delete(int id);
    }
}
