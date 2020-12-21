using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideItem : MonoBehaviour
{
    public string GameObjectName;
    public GameObject[] HideItems;
    public int MaxItemAmount;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= MaxItemAmount; i++)
        {
            HideItems[i].SetActive(false);
        }
    }

    public void OpenItems()
    {
        for (int i = 0; i <= MaxItemAmount; i++)
        {
            HideItems[i].SetActive(true);
        }
    }
}
