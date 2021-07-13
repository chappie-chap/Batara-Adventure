using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField]
    private Transform centerBackground;
  
    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position.x >= (centerBackground.position.x + 12.57f))
        {
            centerBackground.position = new Vector3(centerBackground.position.x + 12.57f, centerBackground.position.y);
        }else if(transform.position.x <= (centerBackground.position.x - 12.57f))
        {
            centerBackground.position = new Vector3(centerBackground.position.x - 12.57f, centerBackground.position.y);
        }
    }
}
