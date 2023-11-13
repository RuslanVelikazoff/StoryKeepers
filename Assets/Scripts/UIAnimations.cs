using UnityEngine;
using DG.Tweening;

public class UIAnimations
{

    #region SettingsPanel

    public void OpenSettingsPanel(GameObject settingsPanel)
    {
        settingsPanel.SetActive(true);
    }
    public void CloseSettingsPanel(GameObject settingsPanel)
    {
        settingsPanel.SetActive(false);
    }

    #endregion

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
