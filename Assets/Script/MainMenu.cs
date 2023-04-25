using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject InGame;
    public GameObject GameOver;
    public void PlayPressed()
    {
        Mainmenu.gameObject.SetActive(false);
        InGame.gameObject.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Mainmenu.gameObject.SetActive(true);
        InGame.gameObject.SetActive(false);
        GameOver.gameObject.SetActive(false);
    }
}
