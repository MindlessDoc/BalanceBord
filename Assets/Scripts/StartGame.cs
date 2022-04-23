using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private Button _startButton;

    void Awake()
    {
        _startButton = GetComponent<Button>();
        _startButton.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        SceneManager.LoadScene(1);
    }
}
