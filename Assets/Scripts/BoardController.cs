using UnityEngine;
using UnityEngine.SceneManagement;

public class BoardController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private Renderer _renderer;

    [SerializeField] private float _downForceValue;
    [SerializeField] private float _horizontalForceValue;
    [SerializeField] private float _hindrance;
    [SerializeField] private float _boostHidrance = 10;
    private int _lvl = 0;
    private int _boostLvl = 0;

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
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Earth")
        {
            SceneManager.LoadScene(2);
        }
    }

    private void FixedUpdate()
    {
        //УСЛОЖНЕНИЕ СО ВРЕМЕНЕМ
        if (PlayerPrefs.GetFloat("timer") / _hindrance > _lvl)
        {
            _lvl++;
            int side = Random.Range(0, 1);
            float prev = _downForceValue;
            _downForceValue = Random.Range(15f, 25f);
            if (PlayerPrefs.GetFloat("timer") / _boostHidrance > _boostLvl && _hindrance > 1)
            {
                _boostLvl++;
                _hindrance--;
            }
            if (side == 0)
            {
                GoRight();
            }
            else
            {
                GoLeft();
            }
            _downForceValue = prev;
        }
    }
}
