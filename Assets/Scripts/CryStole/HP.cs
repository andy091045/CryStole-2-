using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HP : MonoBehaviour
{
    public int combo = 0;
    public bool deadappear = false;
    public static HP Instance;
    public int hpCount = 50;
    public GameObject HP_UI;
    public GameObject combo_UI;
    public Text PowerNumber;
    private void Awake()
    {
        Instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        HP_UI.GetComponent<TMP_Text>().text = hpCount + " ";
        combo_UI.GetComponent<TMP_Text>().text = combo + " ";
        PowerNumber.text = hpCount + " ";
    }
    public void CountHP(int n)
    {
        switch (n)
        {
            case 1:

                combo += 1;
                // Debug.Log("Perfect!!!  combo:" + combo);
                hpCount += 2; //打到方塊加2分 
                // Debug.Log("hpCount:"+hpCount);
                break;
            case 2:

                combo += 1;
                // Debug.Log("Good!!!  combo:" + combo);
                hpCount += 2; //打到方塊加2分 
                // Debug.Log("hpCount:"+hpCount);
                break;
            case 3:
                combo = 0;
                // Debug.Log("combo:" + combo + "combo歸零");
                hpCount -= 20; //沒打到方塊扣20分
                // Debug.Log("hpCount:"+hpCount);
                break;
            case 4:
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
