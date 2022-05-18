using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;

    [SerializeField] private bool isPaused;

    float camSensitivity = 10;
    float volume = 0.5f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }

        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
        isPaused = true;
    }

    public void DeactivateMenu()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }

    void OnGUI()
    {
        if (isPaused)
        {
            if (GUI.Button(new Rect(0, 200, 200, 50), "Reset Settings"))
            {
                camSensitivity = 10;
                volume = 0.5f;
            }
            GUI.Label(new Rect(25, 0, 200, 25), "Camera Sensitivity:");
            camSensitivity = GUI.HorizontalSlider(new Rect(25, 25, 100, 30), camSensitivity, 1, 50);
            PlayerPrefs.SetFloat("Sensitivity", camSensitivity);

            GUI.Label(new Rect(250, 250, 1000, 250), "Volume");
            volume = GUI.HorizontalSlider(new Rect(250, 250, 1000, 300), volume, 0, 1);
            PlayerPrefs.SetFloat("Volume", volume);

        }

    }
}
