using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndData : MonoBehaviour
{
    public UnityEvent access = null;
    public UnityEvent fade = null;
    public UnityEvent change = null;
    // Start is called before the first frame update
    void Start()
    {
        fade.Invoke();
        // StartCoroutine(Example());
        access.Invoke();            
    }
     IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
    }
}
