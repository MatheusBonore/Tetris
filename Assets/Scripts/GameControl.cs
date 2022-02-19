using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public bool pause;
    public Transform pauseMenu;

    private void Start()
    {
        this.pause = false;
    }

    public void PauseGame()
    {
        this.pause = !this.pause;
        this.pauseMenu.gameObject.SetActive(this.pause);

        if (this.pause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
