using System.Collections.Generic;
using Mobilize.Alternative.Models;

namespace Mobilize.Alternative.Presenters
{
  /// <summary>
  /// 
  /// </summary>
  public interface IGameListTask<T>
  {
    IEnumerable<T> GetListOfEntities();

  }


  public class GameListTask : IGameListTask<BoardGame>
  {
    IEnumerable<BoardGame> IGameListTask<BoardGame>.GetListOfEntities()
    {
      return new BoardGameRepository().Get();
    }
  }

  public class StreetGameListTask : IGameListTask<StreetGame>
  {
    IEnumerable<StreetGame> IGameListTask<StreetGame>.GetListOfEntities()
    {
      return new StreetGameRepository().Get();
    }
  }

}