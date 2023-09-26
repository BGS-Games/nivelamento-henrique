using CardSystemUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CardSystem;
using CommonUse;
using System;
using System.IO;
using UnityFoundation.Code;
using TMPro;

namespace CardSystemUI
{    
    public class GameControl : Singleton<GameControl>
    {     
        public GameObject menuMainPanel;     

        public void StartGame()
        { 
            SetMenus();            
        }

        private void SetMenus()
        {
            GeneralMethods.DeactivateMenuAnimateY(menuMainPanel, 1100);
            
            CallActionMenu();

        }

        private void CallActionMenu()
        {
            if(PlayerPrefs.GetInt("ActionType") == 1)
            {
                DistributeCardMenuControl.Instance.InitializeMenu();
            }
            else
            {
                DrawCardMenuControl.Instance.InitializeMenu();
            }                     
        }
    }
}