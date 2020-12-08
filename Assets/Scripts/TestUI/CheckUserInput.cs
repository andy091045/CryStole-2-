using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUserInput : MonoBehaviour
{
    public GameObject UIMenu;
    public bool menu = false;
    public static CheckUserInput Instance;
    // public AudioSource audioSource;
    bool isPaused = false;
    public Canvas Canvas_HUD;
    public Canvas Canvas_Paused;
    // Start is called before the first frame update

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        Canvas_Paused.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.isPaused)
        {

        }
        CheckUser();
    }

    public void CheckUser()
    {

        if (menu == true)
        {
            if (Time.timeScale == 1)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
            menu = false;
        }

    }
    void PauseGame()
    {
        Time.timeScale = 0;
        // audioSource.Pause();
        isPaused = true;
        Canvas_HUD.enabled = false;
        Canvas_Paused.enabled = true;
        UIMenu.SetActive(true);
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        // audioSource.Play();
        isPaused = false;
        Canvas_HUD.enabled = true;
        Canvas_Paused.enabled = false;
        UIMenu.SetActive(false);
    }
}
