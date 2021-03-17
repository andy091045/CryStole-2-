using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Image m_image;
    public Color32 m_NormalColor = Color.white;
    public Color32 m_HoverColor = Color.grey;
    public Color32 m_DownColor = Color.white;
    // Start is called before the first frame update

    public void NormalColor(){
        m_image.color = m_NormalColor;
    }
      public void HoverColor(){
        m_image.color =  m_HoverColor;
    }
      public void DownColor(){
        m_image.color =  m_DownColor;
    }

}
