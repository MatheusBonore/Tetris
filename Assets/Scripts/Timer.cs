using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{
    public Text textBox;
    private TimeSpan timeSpan;
    private bool timerBool;
    private float timeStart;

    public void Initialize()
    {
        this.textBox.text = "00:00";
        this.timerBool = false;
        this.timeStart = 0f;
    }

    public void Start()
    {
        StartCoroutine(ActUpdate());
    }

    public void StartTimer()
    {
        this.timeStart = 0f;
        this.timerBool = true;
    }

    public void StopTimer()
    {
        this.timerBool = false;
    }

    public void PauseTimer()
    {
        this.timerBool = false;
    }

    private IEnumerator ActUpdate()
    {
        while (this.timerBool)
        {
            this.timeStart += Time.deltaTime;
            this.timeSpan = TimeSpan.FromSeconds(this.timeStart);
            this.textBox.text = this.timeSpan.ToString("mm':'ss");

            yield return null;
        }
    }
}
