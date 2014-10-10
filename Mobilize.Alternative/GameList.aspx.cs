using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Mobilize.Alternative.Models;
using Mobilize.Alternative.Presenters;

namespace Mobilize.Alternative
{
  public partial class GameList : System.Web.UI.Page, IGameListView<BoardGame>
  {

    private GameListPresenter<BoardGame> _Presenter;

    public GameList()
    {
      this._Presenter = new GameListPresenter<BoardGame>(this, new GameListTask());
    }

    /// <summary>
    /// Gets or sets the games.
    /// </summary>
    /// <value>The games.</value>
    public IEnumerable<BoardGame> Games
    {
      get
      {
        return null;
      }
      set
      {
        gamesGrid.DataSource = value;
        gamesGrid.DataBind();
      }
    }

  }

}