
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {

    public void Quit(){
        Debug.Log("quit");
        Application.Quit();
    }

    public void restartGame(){
        Debug.Log("Menu");
        SceneManager.LoadScene("Menu");
    }

}
