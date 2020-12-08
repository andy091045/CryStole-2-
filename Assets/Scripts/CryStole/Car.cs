using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public GameObject[] wayPoints;
    private int index = 0;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        // var angle = transform.rotation.x;
        // if (angle > 10)
        // {
        //     speed = 20;
        // }
        // else if (angle < 10 && angle > 0)
        // {
        //     speed = 10;
        // }
        // else if (angle < 0)
        // {
        //     speed = 5;
        // }
        var distance = Vector3.Distance(transform.position, wayPoints[index].transform.position);
        if (distance < 0.5f)
        {
            index++;
        }
        float step = speed * Time.deltaTime;
        var targetrotation = Quaternion.LookRotation(wayPoints[index].transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetrotation, speed * Time.deltaTime * 0.2f);
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[index].transform.position, step);
    }
}
