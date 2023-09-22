using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;


namespace CommonUse
{
    public static class GeneralMethods
    {
        public static void ActivateMenuAnimateX(GameObject menu, float positionX)
        {
            menu.SetActive(true);
            LeanTween.moveX(menu.GetComponent<RectTransform>(), positionX, 0.6f)
                     .setEase(LeanTweenType.easeInOutBack);            
        }

        public static void DeactivateMenuAnimateX(GameObject menu, float positionX) 
        {
            LeanTween.moveX(menu.GetComponent<RectTransform>(), positionX, 0.6f)
                     .setEase(LeanTweenType.easeInOutBack);
            menu.SetActive(false);            
        }

        internal static void DeactivateMenuAnimateY(GameObject menu, float postionY)
        {
            LeanTween.moveY(menu.GetComponent<RectTransform>(), postionY, 0.6f);                     
            menu.SetActive(false);
        }
    }
}

