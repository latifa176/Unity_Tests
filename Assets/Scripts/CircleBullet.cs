using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleBullet : MonoBehaviour
{
    float speed = 6.5f;
    Vector2 point1 = new Vector2(-4, -4);
    Vector2 point2 = new Vector2(4, 4);
    Vector2 targetPoint;
    // Start is called before the first frame update
    void Start()
    {
        targetPoint = point2;
    }
    void UpdateTargetPoint()
    {
        if(Vector2.Distance(transform.position, point1) < 0.1f)
        {
            targetPoint = point2;
        }
        else if(Vector2.Distance(transform.position, point2) < 0.1f)
        {
            targetPoint = point1;
        }
    }
    void MoveToTargetPoint()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPoint, Time.deltaTime * speed);
    }
    // Update is called once per frame
    void Update()
    {
        UpdateTargetPoint();
        MoveToTargetPoint();
    }
}
