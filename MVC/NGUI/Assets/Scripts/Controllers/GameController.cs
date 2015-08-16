using UnityEngine;
using System.Collections;

namespace SocialPoint.Examples.MVC {

    public class GameController {

        GameModel m_gameModel { get; set; }
        WindowViewPresenter m_windowViewPresenter { get; set; }

        public GameController ( ) {
            m_gameModel = new GameModel( );
            m_windowViewPresenter = CreateView("window").GetComponent<WindowViewPresenter>( );

            m_windowViewPresenter.Button1.Clicked += ( s, e ) => {
                m_gameModel.NewGame( );
            };
            m_windowViewPresenter.Button2.Clicked += ( s, e ) => {
                m_gameModel.PauseGame( );
            }; 
        }

        GameObject CreateView ( string viewName ) {
            // Loads the prefab with the view and instantiates it inside the View hierarchy
            return GameObject.Find(viewName);
        }

    }

}


