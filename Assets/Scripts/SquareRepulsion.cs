using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SquareRepulsion : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 mouseWorldPosition;
    public Vector2 velocity;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity.x = 0;
        velocity.y = 0;
    }

    public void Restart()
    {
        //Destroys the gameobject
        Destroy(gameObject);
        //Restarts the level
        SceneManager.LoadScene(0);
    }
    
    // Update is called once per frame
    void Update()
    {
        
        //Getting the location of the cursor in pixels and then converting it into world position
        mouseWorldPosition.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        mouseWorldPosition.y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        
        
        //Initial rigidbody location
        Vector2 rb_initial;

        rb_initial.x = rb.position.x;
        rb_initial.y = rb.position.y;

        //Checking if cursor is in 1 unit circle in  with the rigidbody
        if ((rb.position.x - mouseWorldPosition.x) * (rb.position.x - mouseWorldPosition.x) < 4 && ((rb.position.y - Camera.main.ScreenToWorldPoint(Input.mousePosition).y) * (rb.position.y - Camera.main.ScreenToWorldPoint(Input.mousePosition).y)) < 4)
        {
            //Multiplying by 100 so that
            //travels little large distance esily visible to person playing th game
            //velocity is proportional to distance between cursor and body
            velocity.x = (float)100 * (rb.position.x - mouseWorldPosition.x);
            
            //to store initial velocity in x
            float temp_velocityx = velocity.x;


            while (temp_velocityx * velocity.x > 0)
            {
                // velocity of y is 0 so that it doesn't jump    
                velocity.y = 0;
                
                //Updating the position of the body
                rb.position = rb_initial + (velocity) * Time.deltaTime;
                
                //This part acts as friction and reduces speed so that it stops eventually
                if (velocity.x > 0)
                {
                    velocity.x -= (float)10;
                }
                else
                {
                    velocity.x += (float)10;
                }
            }
            
            velocity.x = 0;
            


        }
        //Checks if in air so that it can't double jump
        float in_air = 0;

        if (Input.GetMouseButton(0) && in_air==0)
        {
            //velocity set to 8 because it gives decent height
            velocity.y = 8;
            in_air = 1;
        }
        while ( velocity.y > 0)
        {

            rb.position = rb_initial + (velocity) * Time.deltaTime;
            velocity.y -= 8;
            in_air = 0;
        }
        
        

    }

    //if cursor enters the box .ie. touches the box, then Restart
    private void OnMouseEnter()
    {
        Restart();
    }
}
