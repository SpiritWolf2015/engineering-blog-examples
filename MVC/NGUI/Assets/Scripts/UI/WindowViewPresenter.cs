using UnityEngine;
using System.Collections;

namespace SocialPoint.Examples.MVC {

    public class WindowViewPresenter : ViewPresenter {

        public ButtonViewPresenter Button1;
        public ButtonViewPresenter Button2;

        public override void Show ( ) {
            Button1.Show( );
            Button2.Show( );        

            base.Show( );
        }

        public override void Hide ( ) {
            Button1.Hide( );
            Button2.Hide( );      

            base.Hide( );
        }
    }

}


