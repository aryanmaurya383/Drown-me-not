using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DiverRepulsion : MonoBehaviour
{
    public static Rigidbody2D rb;

    public static Vector2 mouseWorldPosition;
    public Vector2 velocity;
    public static Vector2 radius;
    
    public static float relativeMousePlayerUnitPosition;
    public static float finalScore;
    public bool isGrounded;
    public static bool diverFacingRight;

    public AudioSource JumpSFX;
    public static AudioSource GameOverSFX;

    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        velocity.x = 0;
        velocity.y = 0;
        
        radius.x = 2;
        radius.y = 2;
                
        isGrounded = false;
        diverFacingRight = true;

        GameOverSFX = GetComponent<AudioSource>();

        finalScore = 0;
    }

    
    
    
    public void playerMovement(Vector2 mouseWorldPosition, Rigidbody2D rb, Vector2 radius, Vector2 velocity)
    {
        //Initial rigidbody location
        Vector2 rb_initial;

        rb_initial.x = rb.position.x;
        rb_initial.y = rb.position.y;

        //Checking if cursor is in 1 unit circle in  with the rigidbody
        if (Mathf.Abs(rb.position.x - mouseWorldPosition.x) <radius.x && (Mathf.Abs(rb.position.y - Camera.main.ScreenToWorldPoint(Input.mousePosition).y) ) < radius.y)
        {
            //Multiplying by 10 so that travels little large distance easily visible to person playing th game
            //velocity is inversely proportional to distance between cursor and body
            velocity.x = (float)10 / (rb.position.x - mouseWorldPosition.x);

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
    }

    
   
    
    
    
    public static void Restart(AudioSource GameOverSFX)
    {
        //Destroys the gameobject
        Destroy(rb.gameObject);
        Cursor.visible = true;
        //Takes to home page
        SceneManager.LoadScene("GameOverScene");
        GameOverSFX.Play();
        Time.timeScale = 0f;

        if (ScoreCounter.scoreValue > finalScore)
        {
            finalScore = ScoreCounter.scoreValue;
        }
    }

    





    // Update is called once per frame
    void Update()
    {
        
        //Getting the location of the cursor in pixels and then converting it into world position
        mouseWorldPosition.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        mouseWorldPosition.y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;

        
        
        relativeMousePlayerUnitPosition = transform.position.x - mouseWorldPosition.x / Mathf.Abs(transform.position.x - mouseWorldPosition.x);
        //Player Movement
        playerMovement(mouseWorldPosition, rb, radius, velocity);

        if (mouseWorldPosition.x >= transform.position.x && !diverFacingRight)
        {
            //this.GetComponent<SpriteRenderer>().flipX = false;
            transform.Rotate(0f, 180f, 0f);
            diverFacingRight = true;
            
        }
        else if (mouseWorldPosition.x < transform.position.x && diverFacingRight)
        {
            //this.GetComponent<SpriteRenderer>().flipX = true;
            transform.Rotate(0f, 180f, 0f);
            diverFacingRight = false;
            
        }

        //If left click and player is on ground then jump
        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            rb.AddForce(new Vector2(0f, 400f));
            JumpSFX.Play();
        }

        if(CameraMovement.cameraPosition.position.x-rb.position.x > 12)
        {
            Restart(GameOverSFX);
        }

    }
    
    
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground1")|| collision.gameObject.CompareTag("Ground2")|| collision.gameObject.CompareTag("Ground3")|| collision.gameObject.CompareTag("Ground4"))
        {
            isGrounded = true;
        }
        
    }
   
    
    
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground1") || collision.gameObject.CompareTag("Ground2") || collision.gameObject.CompareTag("Ground3") || collision.gameObject.CompareTag("Ground4"))
        {
            isGrounded = false;
        }
        
    }

  
    
    
    
    //if cursor enters the box ie. touches the box, then Restart
    private void OnMouseEnter()
    {
        if (Time.timeScale != 0)
        {
            Restart(GameOverSFX);
        }
    }
    
    
}
