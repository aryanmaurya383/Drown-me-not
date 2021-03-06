using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGround : MonoBehaviour
{
    private int collision_counter = 0;
    private bool first_stone = true;
    private int max_bounces = 2;
    private int right_click = 0;
    private float timeSinceRest;

    private void Start()
    {
        timeSinceRest = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision_counter++;
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision_counter = max_bounces;
        }
    }
    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            right_click++;
        }
        if (right_click >= 2)
        {
            first_stone = false;
        }
        if (collision_counter == max_bounces || timeSinceRest>0.5)
        {
            collision_counter = 0;
            timeSinceRest = 0;
            if (!first_stone)
            {
                Destroy(this.gameObject);
            }


        }
        if(Projectile.rb && Projectile.rb.velocity == new Vector2(0, 0))
        {
            timeSinceRest += Time.deltaTime;
        }
    }
}