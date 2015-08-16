using UnityEngine;
using System.Collections;
using System;


namespace SocialPoint.Examples.MVC {
    public class GameModel {

        // Use this for initialization
        public GameModel ( ) {

        }

        public event Action NewGameEvent;
        public event EventHandler StartGame;
        public event Action PauseGameEvent;
        public event EventHandler GameOver;

        public int GameTime { get; private set; }

        public void NewGame ( ) {
            Debug.Log(string.Format("GameModel->NewGame (  )"));
            OnNewGame( );
        }

        protected virtual void OnNewGame ( ) {
            if ( null != NewGameEvent ) {
                NewGameEvent( );
            }
        }

        public void PauseGame ( ) {
            Debug.Log(string.Format("GameModel->PauseGame (  )"));
            OnPauseGame( );
        }

        protected virtual void OnPauseGame ( ) {
            if ( null != PauseGameEvent ) {
                PauseGameEvent( );
            }
        }

    }
}

