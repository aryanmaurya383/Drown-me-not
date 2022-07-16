using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    public GameObject Ground1;
    public GameObject Ground2;
    public GameObject Ground3;
    public GameObject Ground4;

    public void GroundSpawn()
    {
        int randomNum = Random.Range(1, 5);
        
        if (randomNum == 1)
        {
            Instantiate(Ground1, new Vector3(transform.position.x + 16, -3.9f, 0f), Quaternion.identity);
            
        }
        else if (randomNum == 2)
        {
            Instantiate(Ground2, new Vector3(transform.position.x + 16, -3.7f, 0f), Quaternion.identity);
            
        }
        else if (randomNum == 3)
        {
            Instantiate(Ground3, new Vector3(transform.position.x + 13, -2.26f, 0f), Quaternion.identity);
            
        }
        else if (randomNum == 4)
        {
            Instantiate(Ground4, new Vector3(transform.position.x + 15, -3.75f, 0f), Quaternion.identity);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            transform.position += new Vector3(24f, 0f, 0f);
            GroundSpawn();
            
        }
    }






}
