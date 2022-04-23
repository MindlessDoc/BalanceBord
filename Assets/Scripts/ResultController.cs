using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultController : MonoBehaviour
{
    private Text _timerText;

    private void Awake()
    {
        _timerText = GetComponent<Text>();
        _timerText.text = PlayerPrefs.GetFloat("timer").ToString();
    }
}
