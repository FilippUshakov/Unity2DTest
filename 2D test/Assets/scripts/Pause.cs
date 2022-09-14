using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject PauseUI;
    bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        ActivatePause(isPaused);

    }
    void ActivatePause(bool activate) {
        if (activate)
        {
            Time.timeScale = 0f;
            PauseUI.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            PauseUI.SetActive(false);
            isPaused = false;
        }
    }
    public void ContinueGame() {
        ActivatePause(false);
    }
    public void Settings()
    {
        //ActivatePause(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
