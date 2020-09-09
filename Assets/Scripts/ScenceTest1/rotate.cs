using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    bool rotatebool = false;
    public float speed = 20.0f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RotatePoint"))
        {
            Debug.Log("旋轉");
            rotatebool = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rotatebool == true)
        {
            gameObject.transform.parent.transform.Rotate(new Vector3(0, -10, 0) * speed * Time.deltaTime);
        }
    }
}
