using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class FloatingText : MonoBehaviour
{
    public float DestroyTime = 3.0f;
    public Vector3 Offset = new Vector3(0, 2, 0);
    // Start is called before the first frame update
    void Start()
    {
        Lean.Pool.LeanPool.Despawn(gameObject, DestroyTime);
        transform.localPosition += Offset;
    }
}
