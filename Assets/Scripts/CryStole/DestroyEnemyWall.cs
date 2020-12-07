using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("blueEnemy"))
        {
            HP.Instance.CountHP(2);
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("purpleEnemy"))
        {
            HP.Instance.CountHP(2);
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("redEnemy"))
        {
            HP.Instance.CountHP(2);
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("yellowEnemy"))
        {
            HP.Instance.CountHP(2);
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
