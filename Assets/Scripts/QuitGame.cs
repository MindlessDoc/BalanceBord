using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    private Button _quitButton;

    void Awake()
    {
        _quitButton = GetComponent<Button>();
        _quitButton.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        Application.Quit();
    }
}
