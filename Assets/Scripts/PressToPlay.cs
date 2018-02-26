
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressToPlay : MonoBehaviour
{

    public static bool gameIsStarted = true;
    public GameObject pressToStartUI;

   void Start()
    {
        pressToStartUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsStarted = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!gameIsStarted)
            {
                Resume();
            }
        }
    }

    public void Resume()
    {
        pressToStartUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsStarted = false;
    }
}

