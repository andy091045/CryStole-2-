using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class CheckUserInput : MonoBehaviour
{
    //這個東西放在 CAR -> VR選單按紐 -> UI切換
    //輸掉遊戲不能在按Paused
    public bool cannotPaused =false;
    AudioSource audiosource;
    public AudioClip impact;
    public GameObject UIMenu;
    public bool menu = false;
    public static CheckUserInput Instance;
    // public AudioSource audioSource;
    bool isPaused = false;
    public Canvas Canvas_HUD;
    public Canvas Canvas_Paused;
    public Canvas Canvas_Lose;
    public Canvas Canvas_End;
    // Start is called before the first frame update

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        ReStartGame();
        audiosource = GetComponent<AudioSource>();
        Canvas_Paused.enabled = false;
        Canvas_Lose.enabled = false;
        Canvas_End.enabled = false;
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
        audiosource.Pause();
        isPaused = true;
        Canvas_HUD.enabled = false;
        Canvas_Paused.enabled = true;
        UIMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        audiosource.Play();
        isPaused = false;
        cannotPaused=false;
        Canvas_HUD.enabled = true;
        Canvas_Paused.enabled = false;
        UIMenu.SetActive(false);
    }
    public void ReStartGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        Canvas_HUD.enabled = true;
        Canvas_Paused.enabled = false;
        UIMenu.SetActive(false);
    }
    public void LoseGame()
    {
        audiosource.Pause();
        CarType2.Instance.speed = 0;
        UIMenu.SetActive(true);
        RightWeapon.Instance.PauseChange();
        Canvas_Lose.enabled = true;
    }
    public void EndGame()
    {
        audiosource.Pause();
        UIMenu.SetActive(true);
        RightWeapon.Instance.PauseChange();
        Canvas_End.enabled = true;
    }
    public void PlayMusic()
    {
        audiosource.Play();
    }
    //管理canvas、ui的管理，功能有暫停遊戲呼叫選單，跳出輸掉畫面，跳出結算畫面
}
