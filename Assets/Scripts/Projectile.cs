using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Projectile : MonoBehaviour
{
   public static float speed = 14f;
   public static Rigidbody2D rb;

   void Start ()
   {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right *speed ;
        

    }
    
}