using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTiles : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startPositin;
    Vector3 nextPosition;

    private void Start()
    {
        nextPosition = startPositin.position;
    }

    private void Update()
    {
        if(transform.position == pos1.position)
        {
            nextPosition = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextPosition = pos1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime);
    }
}
