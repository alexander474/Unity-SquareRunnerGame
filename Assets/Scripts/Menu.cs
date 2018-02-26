
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void StartGame() {
        SceneManager.LoadScene("Level01");
    }

    public void Settings(){
            Debug.Log("Settings");
            SceneManager.LoadScene("Settings");
    }
    public void Levels()
    {
        Debug.Log("Levels");
        SceneManager.LoadScene("LevelsMenu");
    }

    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }



}
