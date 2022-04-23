using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Renderer _renderer;
    
    [SerializeField] private float _downForceValue = 20;
    [SerializeField] private float _horizontalForceValue = 50;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _renderer = GetComponent<Renderer>();
    }

    public void GoLeft()
    {
        _rigidbody2D.AddForceAtPosition(-transform.up * _downForceValue, _renderer.bounds.min);
        _rigidbody2D.AddForce(-transform.right * _horizontalForceValue);
    }
    
    public void GoRight()
    {
        _rigidbody2D.AddForceAtPosition(-transform.up * _downForceValue, _renderer.bounds.max);
        _rigidbody2D.AddForce(transform.right * _horizontalForceValue);
    }
}
