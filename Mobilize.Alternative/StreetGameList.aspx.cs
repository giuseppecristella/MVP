using System;
using System.Collections.Generic;
using Mobilize.Alternative.Models;
using Mobilize.Alternative.Presenters;

namespace Mobilize.Alternative
{
  public partial class StreetGameList : System.Web.UI.Page, IGameListView<StreetGame>
  {
    private GameListPresenter<StreetGame> _Presenter;

    public StreetGameList()
    {
      this._Presenter = new GameListPresenter<StreetGame>(this, new StreetGameListTask());
    }

    //protected void Page_Load(object sender, EventArgs e)
    //{
    //  // istanzio il presenter
    //  this._Presenter = new GameListPresenter<StreetGame>(this, new StreetGameListTask());

    //}

    public IEnumerable<StreetGame> Games
    {
      get
      {
        return null;
      }
      set
      {
        rptStreetGames.DataSource = value;
        rptStreetGames.DataBind();
      }
    }
  }
}