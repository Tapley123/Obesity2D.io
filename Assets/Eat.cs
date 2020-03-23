using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    private Transform playerSprite;
    [SerializeField] float massIncreseAmount = 1.2f;

    void Start()
    {
        playerSprite = GameObject.Find("PlayerSprite").transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Food"))
        {
            playerSprite.localScale *= massIncreseAmount;
            GameObject go = collision.gameObject;
            Destroy(go);
        }
    }
}
