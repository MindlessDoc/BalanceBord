using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoMenu : MonoBehaviour
{
    private Button _goMenuButton;

    void Awake()
    {
        _goMenuButton = GetComponent<Button>();
        _goMenuButton.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        SceneManager.LoadScene(0);
    }
}
