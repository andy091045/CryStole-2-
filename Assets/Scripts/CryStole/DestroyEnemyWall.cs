using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("blueEnemy"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("purpleEnemy"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("redEnemy"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("yellowEnemy"))
        {
            Destroy(other.gameObject);
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
