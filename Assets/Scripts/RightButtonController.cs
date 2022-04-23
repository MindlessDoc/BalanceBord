using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButtonController : MonoBehaviour
{
    [SerializeField] private BoardController _boardController;
    
    private bool _rightPressed = false;
    
    public void OnRightDown()
    {
        _rightPressed = true;
    }
    
    public void OnRightUp()
    {
        _rightPressed = false;
    }
    
    private void FixedUpdate()
    {
        if (_rightPressed)
        {
            _boardController.GoRight();
        }
    }
}
