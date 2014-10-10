using System;
using System.Collections.Generic;
using System.Linq;

namespace Mobilize.Alternative.Models
{
    public class BoardGameRepository
    {

        private static readonly List<BoardGame> _Games = new List<BoardGame>
        {
            new BoardGame
            {
                Id = 1,
                Name = "Chess",
                Manu = "Big Games Inc.",
                Price = 8.99M
            },
            new BoardGame
            {
                Id = 2,
                Name = "Checkers",
                Manu = "Big Games Inc.",
                Price = 5.99M
            },
            new BoardGame
            {
                Id = 3,
                Name = "Backgammon",
                Manu = "Classic Games Inc.",
                Price = 13.99M
            },
            new BoardGame
            {
                Id = 4,
                Name = "Dominoes",
                Manu = "Classic Games Inc.",
                Price = 7.99M
            }
        };

        public IQueryable<BoardGame> Get(Func<BoardGame, bool> where = null)
        {

            where = where ?? (_ => true);

            return _Games.Where(where).AsQueryable();

        }

    }

}