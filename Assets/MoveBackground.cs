using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField]
    private Transform Bgcenter;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= Bgcenter.position.x + 13.568f)
        {
            Bgcenter.position = new Vector3(Bgcenter.position.x, transform.position.x + 13.568f);
        }
        else
        {
            Bgcenter.position = new Vector3(Bgcenter.position.x, transform.position.x + -13.568f);
        }
    }
}
