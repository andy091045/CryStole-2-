using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    public Material Material_1;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material = Material_1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
