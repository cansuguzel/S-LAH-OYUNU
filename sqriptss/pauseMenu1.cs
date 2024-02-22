using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _inGameMenu;
    private bool check;
    // Start is called before the first frame update
    void Start()
    {
        _pauseMenu.SetActive(false);
        _inGameMenu.SetActive(true);
        check = false;
        
    }
    public void ResumeGame()
    {

        _pauseMenu.SetActive(false);
        _inGameMenu.SetActive(true);
        check = false;
        Cursor.visible = true;
    }
    public void quitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            check = !check;
            Cursor.visible = check;
            _pauseMenu.SetActive(check);
            _inGameMenu.SetActive(!check);

        }
    }
}
