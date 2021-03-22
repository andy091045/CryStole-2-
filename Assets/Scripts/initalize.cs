using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class initalize : MonoBehaviour
{
    public UnityEvent init = null;
    // Start is called before the first frame update
    void Start()
    {
        init.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
