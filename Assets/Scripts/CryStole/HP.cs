using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HP : MonoBehaviour
{
    public bool deadappear = false;
    public static HP Instance;
    int hpCount = 50;
    public GameObject HP_UI;
    private void Awake()
    {
        Instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        HP_UI.GetComponent<TMP_Text>().text = hpCount + " ";
    }
    public void CountHP(int n)
    {
        switch (n)
        {
            case 1:
                //打到方塊加5分            
                hpCount += 5;
                break;
            case 2:
                //沒打到方塊扣10分
                hpCount -= 10;
                break;
            case 3:
                //撞到障礙物扣30分
                hpCount -= 30;
                break;
            default:
                Debug.Log("錯誤輸入");
                break;
        }
        if (hpCount <= 0)
        {
            if (deadappear)
            {
                CheckUserInput.Instance.LoseGame();
            }
            hpCount = 0;
        }
    }
}
