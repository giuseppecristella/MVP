using System;
using System.Collections.Generic;
using System.Linq;

namespace Mobilize.Alternative.Models
{
    public class StreetGameRepository
    {

      private static readonly List<StreetGame> _StreetGames = new List<StreetGame>
        {
            new StreetGame
            {
                Id = 1,
                Name = "Chess"
            } 
       
        };

      public IQueryable<StreetGame> Get(Func<StreetGame, bool> where = null)
        {

            where = where ?? (_ => true);

            return _StreetGames.Where(where).AsQueryable();

        }

    }

}