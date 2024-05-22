using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [HideInInspector] public float ArrowVelocity;

    [SerializeField] Rigidbody2D rb;

    void Start()
    {
        Destroy(gameObject, 4f);    
    }

    void FixedUpdate()
    {
        rb.velocity = transform.up * ArrowVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
