using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement_vertical : MonoBehaviour
{
    public float speed;
    public bool MoveRight;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveRight){
            transform.Translate(Vector2.up*speed*Time.deltaTime);
            
        }
        else{
            transform.Translate(Vector2.down*speed*Time.deltaTime);
            
        }
    }
    void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("turn"))
        {
            if(MoveRight)
            {
                MoveRight=false;
            }
            else{
                MoveRight=true;
            }
        }
                
    }
}
        
    


