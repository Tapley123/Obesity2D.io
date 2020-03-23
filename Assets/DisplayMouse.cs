using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMouse : MonoBehaviour
{
    private float z = 0;
    void Update()
    {
        Vector3 moveTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = moveTarget;
        transform.position = new Vector3(transform.position.x, transform.position.y, z); // this line will alter the z to match the zPos variable
    }
}
