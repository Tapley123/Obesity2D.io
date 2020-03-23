using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private Transform MousePointer;
    private Rigidbody2D rb;

    private float z = 0;

    [SerializeField] private float speed = 5f;
    private Transform playerScale;
    void Start()
    {
        playerScale = GameObject.Find("PlayerSprite").transform;
        MousePointer = GameObject.Find("MousePointer").transform;
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 moveTarget = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotateTarget = new Vector3(transform.position.x, transform.position.y, moveTarget.z);
              
        transform.position = new Vector3(transform.position.x, transform.position.y, z); // this line will alter the z to match the zPos variable
        transform.position = Vector3.MoveTowards(transform.position, moveTarget, speed * Time.deltaTime / playerScale.localScale.x);

        //rotation
        Vector3 direction = MousePointer.position - transform.position; //get the distance between the player and the mouse;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //calculating the roatation and translating it to degrees
        rb.rotation = angle;
    }
}
