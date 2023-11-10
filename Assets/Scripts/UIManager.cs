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

        UpPanelButtonsAction();
        BottomPanelButtonsAction();
        ExitPanelButtonsAction();

        Debug.Log("UIManager initialized");
    }

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
                //TODO: open settings
            });
        }
    }

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
}
