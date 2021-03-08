using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public List<Transform> points = new List<Transform>();
    Transform finalpoint;
    int point = 0;
    bool reverse;
    // Start is called before the first frame update
    void Start()
    {
        finalpoint = points[point];
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, finalpoint.position) > 0.2f)
            transform.position += (finalpoint.position - transform.position).normalized * 8f * Time.deltaTime;
        else
            ChangePatrolPoint();
    }
    void ChangePatrolPoint()
    {
        if (!reverse)
            point++;
        else
            point--;

        if (point >= points.Count)
        {
            point = (points.Count - 1);
            reverse = true;
        }
        else if (point < 0)
        {
            point = 0;
            reverse = false;
        }

        finalpoint = points[point];
    }
}
