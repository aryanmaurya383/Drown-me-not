using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    public GameObject Ground1;
    public GameObject Ground2;
    public GameObject Ground3;
    public GameObject Ground4;

    public bool hasGround;
    private Vector3 prevPosition;
    

    // Start is called before the first frame update
    void Start()
    {
        hasGround = true;
        prevPosition = DiverRepulsion.rb.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x - prevPosition.x >24)
        {
            GroundSpawn();
            prevPosition = transform.position;
        }
    }

    public void GroundSpawn()
    {
        int randomNum = Random.Range(1, 5);
        
        if (randomNum == 1)
        {
            Instantiate(Ground1, new Vector3(transform.position.x + 16, -3.9f, 0f), Quaternion.identity);
        }
        else if (randomNum == 2)
        {
            Instantiate(Ground2, new Vector3(transform.position.x + 16, -3.85f, 0f), Quaternion.identity);
        }
        else if (randomNum == 3)
        {
            Instantiate(Ground3, new Vector3(transform.position.x + 16, -2.26f, 0f), Quaternion.identity);
        }
        else if (randomNum == 4)
        {
            Instantiate(Ground4, new Vector3(transform.position.x + 16, -3.75f, 0f), Quaternion.identity);
        }
    }
    
    
    

}
