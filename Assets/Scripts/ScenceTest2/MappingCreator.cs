using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Lean.Pool;

public class MappingCreator : MonoBehaviour
{
    float timer = 0;
    public GameObject[] cubes;
    public Transform[] points;
    public Transform[] points2;
    Vector3 position = Vector3.zero;
    public TextAsset mapping;
    Music2 data;
    // Start is called before the first frame update
    void Start()
    {
        data = JsonUtility.FromJson<Music2>(mapping.text);
        for (int i = 0; i < 187; i++)
        {
            if (data._events[i]._value <= 1)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[0], points[data._events[i]._type]);
                Vector3 move = cube.transform.position;
                move = new Vector3(move.x, move.y, move.z + 10.0f * data._events[i]._time);
                if (move.z > 100.0f)
                {
                    move.y += 25.0f;
                }
                cube.transform.position = move;
            }
            else if (data._events[i]._value <= 3)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[1], points[data._events[i]._type]);
                Vector3 move = cube.transform.position;
                move = new Vector3(move.x, move.y, move.z + 10.0f * data._events[i]._time);
                if (move.z > 100.0f)
                {
                    move.y += 25.0f;
                }
                cube.transform.position = move;
            }
            else if (data._events[i]._value <= 5)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[2], points[data._events[i]._type]);
                Vector3 move = cube.transform.position;
                move = new Vector3(move.x, move.y, move.z + 10.0f * data._events[i]._time);
                if (move.z > 100.0f)
                {
                    move.y += 25.0f;
                }
                cube.transform.position = move;
            }
            else
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[3], points[data._events[i]._type]);
                Vector3 move = cube.transform.position;
                move = new Vector3(move.x, move.y, move.z + 10.0f * data._events[i]._time);
                if (move.z > 100.0f)
                {
                    move.y += 25.0f;
                }
                cube.transform.position = move;
            }
        }

        for (int i = 187; i < 1000; i++)
        {
            if (data._events[i]._value <= 3)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[0], points2[data._events[i]._type]);
                Vector3 move = cube.transform.position;
                move = new Vector3((move.x + 10 * data._events[i]._time) - 431.0f, move.y, move.z);
                if (move.x > 235.0f)
                {
                    move.y -= 25.0f;
                }
                cube.transform.position = move;
            }
            else
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[1], points2[data._events[i]._type]);
                Vector3 move = cube.transform.position;
                move = new Vector3((move.x + 10 * data._events[i]._time) - 431.0f, move.y, move.z);
                if (move.x > 235.0f)
                {
                    move.y -= 25.0f;
                }
                cube.transform.position = move;
                //物體旋轉
                cube.transform.Rotate(0, 90, 0);
            }
        }
    }
    private void Update()
    {
        timer += Time.deltaTime;
    }
}

[System.Serializable]
public class Mapping
{
    public float _time;
    public int _type;
    public int _value;
}

[System.Serializable]
public class Music2
{
    public Mapping[] _events;
}
