using System;
using System.Collections.Generic;
using Mobilize.Alternative.Models;

namespace Mobilize.Alternative.Presenters
{
  /// <summary>
  /// 
  /// </summary>
  public interface IGameListView<T>
  {

    event EventHandler Load;

    IEnumerable<T> Games { get; set; }

  }

}