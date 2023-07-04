using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPausedGame;
    // Start is called before the first frame update
    void Start()
    {
        isPausedGame = false;
        PausedGame(isPausedGame);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPausedGame = !isPausedGame;
            PausedGame(isPausedGame);
        }
    }
    private void PausedGame(bool _isPausedGame)
    {
        if (_isPausedGame)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
        pauseMenu.SetActive(_isPausedGame);
    }
}
