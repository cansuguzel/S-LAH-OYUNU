using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    [SerializeField] private GameObject infoImage;

    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void ShowInfo()
    {
        infoImage.SetActive(true);
    }

    public void HideInfo()
    {
        infoImage.SetActive(false);
    }
}
