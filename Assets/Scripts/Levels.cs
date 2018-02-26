using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour {

    public void StartLevel01()
    {
        SceneManager.LoadScene("Level01");
    }
    public void StartLevel02()
    {
        SceneManager.LoadScene("Level02");
    }
    public void StartLevel03()
    {
        SceneManager.LoadScene("Level03");
    }
    public void StartLevel04()
    {
        SceneManager.LoadScene("Level04");
    }
    public void StartLevel05()
    {
        SceneManager.LoadScene("Level05");
    }
    public void StartLevel06()
    {
        SceneManager.LoadScene("Level06");
    }
    public void StartLevel07()
    {
        SceneManager.LoadScene("Level07");
    }
    public void StartLevel08()
    {
        SceneManager.LoadScene("Level08");
    }
    public void StartLevel09()
    {
        SceneManager.LoadScene("Level09");
    }
    public void StartLevel10()
    {
        SceneManager.LoadScene("Level10");
    }
    public void StartLevel11()
    {
        SceneManager.LoadScene("Level11");
    }
    public void StartLevel12()
    {
        SceneManager.LoadScene("Level12");
    }
    public void GoBackToLastPage() {
        SceneManager.LoadScene("LevelsMenu");
    }


    public void GoBack()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Next() {
        SceneManager.LoadScene("LevelsMenu02");
    }
}
