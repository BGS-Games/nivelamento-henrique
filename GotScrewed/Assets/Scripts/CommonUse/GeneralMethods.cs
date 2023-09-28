using UnityEngine;

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

        internal static void CleanPanel(GameObject panel)
        {
            foreach(Transform child in panel.transform)
            {
                UnityEngine.Object.Destroy(child.gameObject);
            }
        }

        internal static void DeactivateMenuAnimateY(GameObject menu, float postionY)
        {
            LeanTween.moveY(menu.GetComponent<RectTransform>(), postionY, 0.3f)
                .setEase(LeanTweenType.easeInOutBack)
                .setOnComplete(() => menu.SetActive(false));
        }
    }
}