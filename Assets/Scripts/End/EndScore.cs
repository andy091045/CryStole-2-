using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EndScore : MonoBehaviour
{
    // public GameObject testjson;
    public Text ScoreNumber;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNumber.text = TestJson.Instance.score + " ";
    }

    // Update is called once per frame
    void Update()
    {
ScoreNumber.text = TestJson.Instance.score + " ";
    }
}
