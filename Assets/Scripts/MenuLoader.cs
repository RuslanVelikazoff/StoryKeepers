using UnityEngine;

public class MenuLoader : MonoBehaviour
{
    [SerializeField]
    private UIManager uiManager;

    private UIAnimations animations = new UIAnimations();

    private void Start()
    {
        uiManager.Initialize(animations);
    }
}
