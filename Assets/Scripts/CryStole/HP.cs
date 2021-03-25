using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HP : MonoBehaviour
{
    public bool deadappear = false;
    public static HP Instance;
    public int hpCount = 50;
    public GameObject HP_UI;
    public Text PowerNumber;
    private void Awake()
    {
        Instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        HP_UI.GetComponent<TMP_Text>().text = hpCount + " ";
        PowerNumber.text = hpCount + " ";
    }
    public void CountHP(int n)
    {
        switch (n)
        {
            case 1:
                //打到方塊加2分            
                hpCount += 2;
                break;
            case 2:
                //沒打到方塊扣20分
                hpCount -= 20;
                break;
            case 3:
                //撞到障礙物扣30分
                hpCount -= 50;
                break;
            default:
                Debug.Log("錯誤輸入");
                break;
        }
        if (hpCount <= 0)
        {
            if (deadappear)
            {
                CheckUserInput.Instance.cannotPaused = true;
                CheckUserInput.Instance.LoseGame();
            }
            hpCount = 0;
        }
    }
}
