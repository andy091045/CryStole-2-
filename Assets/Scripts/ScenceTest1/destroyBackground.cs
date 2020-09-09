using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class destroyBackground : MonoBehaviour
{   //銷毀已經沒用的牆節省效能
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Lean.Pool.LeanPool.Despawn(other.gameObject);
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
