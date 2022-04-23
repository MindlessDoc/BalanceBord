using System;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    [SerializeField] private Text _timerText;

    private double _timer = 0;

    private void Awake()
    {
        _timerText = GetComponent<Text>();
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        _timerText.text = Math.Round(_timer, 2).ToString();
        PlayerPrefs.SetString("timer", _timerText.text);
    }
}
