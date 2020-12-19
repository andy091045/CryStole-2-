﻿using System.Collections;
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
        for (int i = 0; i <= 113; i++)
        {
            if (data._notes[i]._cutDirection == 0)
            {
                GameObject cube = LeanPool.Spawn(cubes[0], points[data._notes[i]._lineIndex * 1 + data._notes[i]._lineLayer * 4]);
                Vector3 move = cube.transform.position;
                move = new Vector3(move.x, move.y, move.z + 10.0f * (data._notes[i]._time * 0.46f));
                if (move.z > 100.0f)
                {
                    move.y += 25.5f;
                }
                Debug.Log(i + ":" + move);
                cube.transform.position = move;
            }
            else if (data._notes[i]._cutDirection == 1)
            {
                GameObject cube = LeanPool.Spawn(cubes[1], points[data._notes[i]._lineIndex * 1 + data._notes[i]._lineLayer * 4]);
                Vector3 move = cube.transform.position;
                move = new Vector3(move.x, move.y, move.z + 10.0f * (data._notes[i]._time * 0.46f));
                if (move.z > 100.0f)
                {
                    move.y += 25.5f;
                }
                Debug.Log(i + ":" + move);
                cube.transform.position = move;
            }
            else if (data._notes[i]._cutDirection == 2)
            {
                GameObject cube = LeanPool.Spawn(cubes[2], points[data._notes[i]._lineIndex * 1 + data._notes[i]._lineLayer * 4]);
                Vector3 move = cube.transform.position;
                move = new Vector3(move.x, move.y, move.z + 10.0f * (data._notes[i]._time * 0.46f));
                if (move.z > 100.0f)
                {
                    move.y += 25.5f;
                }
                Debug.Log(i + ":" + move);
                cube.transform.position = move;
            }
            else
            {
                //不要用數值，把他抽成變數，減少自己的工作量，子傑有講喔，不要再犯了
                GameObject cube = LeanPool.Spawn(cubes[3], points[data._notes[i]._lineIndex * 1 + data._notes[i]._lineLayer * 4]);
                Vector3 move = cube.transform.position;
                move = new Vector3(move.x, move.y, move.z + 10.0f * (data._notes[i]._time * 0.46f));
                if (move.z > 100.0f)
                {
                    move.y += 25.5f;
                }
                Debug.Log(i + ":" + move);
                cube.transform.position = move;
            }
        }

        for (int i = 114; i < 1000; i++)
        {
            // Debug.Log(i + ":" + data._notes[i]._type);
            if (data._notes[i]._cutDirection == 0)
            {
                GameObject cube = LeanPool.Spawn(cubes[0], points2[data._notes[i]._lineIndex * 1 + data._notes[i]._lineLayer * 4]);
                Vector3 move = cube.transform.position;
                move = new Vector3((move.x + 10 * data._notes[i]._time * 0.46f) - 391.0f, move.y, move.z);
                if (move.x > 235.0f)
                {
                    move.y -= 26.0f;
                }
                cube.transform.position = move;
                //物體旋轉
                cube.transform.Rotate(0, 90, 0);
            }
            else if (data._notes[i]._cutDirection == 1)
            {
                GameObject cube = LeanPool.Spawn(cubes[1], points2[data._notes[i]._lineIndex * 1 + data._notes[i]._lineLayer * 4]);
                Vector3 move = cube.transform.position;
                move = new Vector3((move.x + 10 * data._notes[i]._time * 0.46f) - 391.0f, move.y, move.z);
                if (move.x > 235.0f)
                {
                    move.y -= 26.0f;
                }
                cube.transform.position = move;
                //物體旋轉
                cube.transform.Rotate(0, 90, 0);
            }
            else if (data._notes[i]._cutDirection == 2)
            {
                GameObject cube = LeanPool.Spawn(cubes[2], points2[data._notes[i]._lineIndex * 1 + data._notes[i]._lineLayer * 4]);
                Vector3 move = cube.transform.position;
                move = new Vector3((move.x + 10 * data._notes[i]._time * 0.46f) - 391.0f, move.y, move.z);
                if (move.x > 235.0f)
                {
                    move.y -= 26.0f;
                }
                cube.transform.position = move;
                //物體旋轉
                cube.transform.Rotate(0, 90, 0);
            }
            else
            {
                GameObject cube = LeanPool.Spawn(cubes[3], points2[data._notes[i]._lineIndex * 1 + data._notes[i]._lineLayer * 4]);
                Vector3 move = cube.transform.position;
                move = new Vector3((move.x + 10 * data._notes[i]._time * 0.46f) - 391.0f, move.y, move.z);
                if (move.x > 235.0f)
                {
                    move.y -= 26.0f;
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
    public int _time;
    public int _lineIndex;
    public int _lineLayer;
    public int _type;
    public int _cutDirection;
}

[System.Serializable]
public class Music2
{
    public Mapping[] _notes;
}
