using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement_horizontal : MonoBehaviour
{
    public float speed;
    public bool MoveRight;
    string nameOfSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //nameOfSprite = this.gameObject.GetComponent<SpriteRenderer>().sprite.name;
        if(MoveRight){
            transform.Translate(2*Time.deltaTime*speed,0,0);
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else{
            transform.Translate(-2*Time.deltaTime*speed,0,0);
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn"))
        {
            if (MoveRight)
            {
                MoveRight = false;
            }
            else
            {
                MoveRight = true;
            }
        }
        
    }
}
