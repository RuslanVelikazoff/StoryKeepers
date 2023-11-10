using UnityEngine;
using DG.Tweening;

public class UIAnimations
{

    #region ExitPanel

    public void OpenExitPanel(GameObject exitPanel)
    {
        exitPanel.SetActive(true);
    }
    public void CloseExitPanel(GameObject exitPanel)
    {
        exitPanel.SetActive(false);
    }

    #endregion
}
