﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class CarType2 : MonoBehaviour
{
    public static CarType2 Instance;
    public PathCreator pathCreator;

    // public  StartofPathInstruction start;
    public EndOfPathInstruction end;
    public float speed = 10;
    float distanceTravelled;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        // You can now access the vertex path with pathCreator.path
        // For example, this sets the position to the middle of the path:
        transform.position = pathCreator.path.GetPoint(0);
    }

    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, end);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, end);
    }
}
