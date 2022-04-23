using UnityEngine;

public class LeftButtonController : MonoBehaviour
{
    [SerializeField] private BoardController _boardController;
    
    private bool _leftPressed = false;
    
    public void OnLeftDown()
    {
        _leftPressed = true;
    }
    
    public void OnLeftUp()
    {
        _leftPressed = false;
    }

    private void FixedUpdate()
    {
        if (_leftPressed)
        {
            _boardController.GoLeft();
        }
    }
}
