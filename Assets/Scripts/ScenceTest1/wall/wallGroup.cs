using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class wallGroup : MonoBehaviour
{
    public GameObject[] Scene;
    public Vector3 tailpos;
    public Transform pos;

    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        tailpos = pos.position;
        SceneBuild(tailpos);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SceneBuild(Vector3 position)
    {
        if (i >= Scene.Length)
        {
            return;
        }
        GameObject cube = Lean.Pool.LeanPool.Spawn(Scene[i], position, Quaternion.Euler(0, 0, 0), pos);
        Debug.Log(Scene[i].name);
        i++;

    }
}
