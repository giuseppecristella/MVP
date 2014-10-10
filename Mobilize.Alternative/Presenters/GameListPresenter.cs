using System;
using Mobilize.Alternative.Models;

namespace Mobilize.Alternative.Presenters
{

  public class GameListPresenter<T>
  {

    private IGameListTask<T> _Task;

    private IGameListView<T> _View;

    public GameListPresenter(IGameListView<T> view, IGameListTask<T> task)
    {

      this._View = view;
      this._Task = task;

      _View.Load += _View_Load;

    }

    void _View_Load(object sender, EventArgs e)
    {
     _View.Games  = _Task.GetListOfEntities();
    }

  }
  
}