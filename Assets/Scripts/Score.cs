using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public Text textBox;
    private int scoreStart;

    public void Initialize()
    {
        this.textBox.text = "00000";
        this.scoreStart = 0;
    }

    public void AddScore()
    {
        this.scoreStart++;
        this.textBox.text = this.scoreStart.ToString("D5");
    }

    public void ResetScore()
    {
        this.scoreStart = 0;
        this.textBox.text = this.scoreStart.ToString("D5");
    }
}
