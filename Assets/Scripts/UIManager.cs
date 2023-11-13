using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("Up panel")]
    [SerializeField]
    private Button addDiamondsButton;
    [SerializeField]
    private Button addKeysButton;

    [Header("Bottom panel")]
    [SerializeField]
    private Button exitButton;
    [SerializeField]
    private Button homeButton;
    [SerializeField]
    private Button settingsButton;

    [Header("Settings panel")]
    [SerializeField]
    private GameObject settingsPanel;
    [SerializeField]
    private Button soundButton;
    [SerializeField]
    private Button musicButton;
    [SerializeField]
    private Sprite onSprite;
    [SerializeField]
    private Sprite offSprite;

    [Header("Exit panel")]
    [SerializeField]
    private GameObject exitPanel;
    [SerializeField]
    private Button yesButton;
    [SerializeField]
    private Button noButton;

    private UIAnimations animations;

    public void Initialize(UIAnimations uIAnimations)
    {
        animations = uIAnimations;

        exitPanel.SetActive(false);

        SetSprites();

        UpPanelButtonsAction();
        BottomPanelButtonsAction();
        SettingsPanelButtonsAction();
        ExitPanelButtonsAction();

        Debug.Log("UIManager initialized");
    }

    #region UpPanel

    private void UpPanelButtonsAction()
    {
        if (addDiamondsButton != null)
        {
            addDiamondsButton.onClick.RemoveAllListeners();
            addDiamondsButton.onClick.AddListener(() =>
            {
                //TODO: add donate
                Debug.Log("Add diamonds");
            });
        }
        if (addKeysButton != null)
        {
            addKeysButton.onClick.RemoveAllListeners();
            addKeysButton.onClick.AddListener(() =>
            {
                //TODO: add donate
                Debug.Log("Add keys");
            });
        }
    }

    #endregion

    #region BottomPanel

    private void BottomPanelButtonsAction()
    {
        if (exitButton != null)
        {
            exitButton.onClick.RemoveAllListeners();
            exitButton.onClick.AddListener(() =>
            {
                animations.OpenExitPanel(exitPanel);
            });
        }
        if (homeButton != null)
        {
            homeButton.onClick.RemoveAllListeners();
            homeButton.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(0);
            });
        }
        if (settingsButton != null)
        {
            settingsButton.onClick.RemoveAllListeners();
            settingsButton.onClick.AddListener(() =>
            {
                animations.OpenSettingsPanel(settingsPanel);
            });
        }
    }

    #endregion

    #region SettingsPanel

    private void SettingsPanelButtonsAction()
    {
        if (musicButton != null)
        {
            musicButton.onClick.RemoveAllListeners();
            musicButton.onClick.AddListener(() =>
            {
                if (PlayerPrefs.GetFloat("MusicVolume") == 1f)
                {
                    AudioManager.instance.OffMusic();
                }
                else
                {
                    AudioManager.instance.OnMusic();
                }

                SetSprites();
            });
        }

        if (soundButton != null)
        {
            soundButton.onClick.RemoveAllListeners();
            soundButton.onClick.AddListener(() =>
            {
                if (PlayerPrefs.GetFloat("SoundVolume") == 1f)
                {
                    AudioManager.instance.OffSound();
                }
                else
                {
                    AudioManager.instance.OnSound();
                }

                SetSprites();
            });
        }
    }

    private void SetSprites()
    {
        if (PlayerPrefs.GetFloat("MusicVolume") == 1f)
        {
            musicButton.GetComponent<Image>().sprite = onSprite;
        }
        else if (PlayerPrefs.GetFloat("MusicVolume") == 0f)
        {
            musicButton.GetComponent<Image>().sprite = offSprite;
        }

        if (PlayerPrefs.GetFloat("SoundVolume") == 1f)
        {
            soundButton.GetComponent<Image>().sprite = onSprite;
        }
        else if (PlayerPrefs.GetFloat("SoundVolume") == 0f)
        {
            soundButton.GetComponent<Image>().sprite = offSprite;
        }
    }

    #endregion

    #region ExitPanel

    private void ExitPanelButtonsAction()
    {
        if (yesButton != null)
        {
            yesButton.onClick.RemoveAllListeners();
            yesButton.onClick.AddListener(() =>
            {
                Application.Quit();
                Debug.Log("Exit game");
            });
        }
        if (noButton != null)
        {
            noButton.onClick.RemoveAllListeners();
            noButton.onClick.AddListener(() =>
            {
                animations.CloseExitPanel(exitPanel);
            });
        }
    }

    #endregion
}
