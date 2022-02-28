using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    public class PlayerCheckService : IPlayerCheckService
    {
        

        bool IPlayerCheckService.CheckIfRealPlayer(Player player)
        {
            return true;
        }
    }
}
