using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject[] photos;
    public ArrowType arrowType;
    int pressNumber = 0;
    public int MaxItemAmount = 0;
    public void PressDownArrow()
    {
        if (arrowType == ArrowType.RightArrow)
        {
            if (pressNumber < MaxItemAmount)
            {
                photos[pressNumber].SetActive(false);
                pressNumber++;
                photos[pressNumber].SetActive(true);
            }

        }
        if (arrowType == ArrowType.LeftArrow)
        {
            if (pressNumber > 0)
            {
                photos[pressNumber].SetActive(false);
                pressNumber--;
                photos[pressNumber].SetActive(true);
            }
        }
    }
    public enum ArrowType
    {
        LeftArrow, RightArrow
    }
}
