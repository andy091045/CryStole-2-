using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class produceBackground : MonoBehaviour
{   //生成新的牆
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Vector3 pos = other.gameObject.transform.GetChild(1).position;
            GameObject wall = GameObject.Find("wallGroup");
            wall.GetComponent<wallGroup>().SceneBuild(pos);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
