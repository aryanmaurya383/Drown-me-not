using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    public GameObject Ground1;
    public GameObject Ground2;
    public GameObject Ground3;
    public GameObject Ground4;
    public GameObject EnemyHorizontal;
    public GameObject EnemyVertical;

    public void GroundSpawn()
    {
        int randomNum = Random.Range(1, 5);
        
        //EnemySpawn(randomNum);
        if (randomNum == 1)
        {
            Instantiate(Ground1, new Vector3(transform.position.x + 11, -3.46f, 0f), Quaternion.identity);
            
        }
        else if (randomNum == 2)
        {
            Instantiate(Ground2, new Vector3(transform.position.x + 10, -1.7f, 0f), Quaternion.identity);
            
        }
        else if (randomNum == 3)
        {
            Instantiate(Ground3, new Vector3(transform.position.x + 9, -1.73f, 0f), Quaternion.identity);
            
        }
        else if (randomNum == 4)
        {
            Instantiate(Ground4, new Vector3(transform.position.x + 10.5f, -3.64f, 0f), Quaternion.identity);
            
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
    //public void EnemySpawn(int terrainNum)
    //{
        //if (terrainNum==1)
        //{
            //Instantiate(EnemyHorizontal, new Vector3(transform.position.x + 11, -3.9f, 0f) - new Vector3(0.951600027f, -6.8499999f, 0) + new Vector3(0.0500000007f, -2.67000008f, -0.0537057072f), Quaternion.identity);
          //  Instantiate(EnemyVertical, new Vector3(transform.position.x + 11, -3.9f, 0f) - new Vector3(11.751600027f, -3.5499999f, 0) + new Vector3(8.00349998f, 0.378899992f, -0.0537057072f), Quaternion.identity);
        //}
        //else if (terrainNum==2)
        //{
           // Instantiate(EnemyHorizontal, new Vector3(transform.position.x + 10, -3.7f, 0f) - new Vector3(-0.439999998f, -5.24999995f, 0f) + new Vector3(0.0500000007f, -2.67000008f, -0.0537057072f), Quaternion.identity);
         //   Instantiate(EnemyVertical, new Vector3(transform.position.x + 10, -3.7f, 0f) - new Vector3(14.439999998f, -1.54999995f, 0f) + new Vector3(7.96000004f, 0.430000007f, -0.0537057072f), Quaternion.identity);
        //}
        //else if (terrainNum==3)
        //{
            //Instantiate(EnemyHorizontal, new Vector3(transform.position.x + 9, -2.26f, 0f) + new Vector3(0.49000001f, -2.42000008f, -0.0537057072f) - new Vector3(3.111990452f, -3.84606848f, 0f), Quaternion.identity);
          //  Instantiate(EnemyVertical, new Vector3(transform.position.x + 9, -2.26f, 0f) + new Vector3(7.96000004f, 0.430000007f, -0.0537057072f) - new Vector3(13.111990452f, 0.54606848f, 0f), Quaternion.identity);
        //}
        //else if (terrainNum==4)
        //{
            //Instantiate(EnemyHorizontal, new Vector3(transform.position.x + 11, -3.75f, 0f) + new Vector3(0.49000001f, -2.42000008f, -0.0537057072f) - new Vector3(-4.210413933f, -5.27163458f, 0f), Quaternion.identity);
          //  Instantiate(EnemyVertical, new Vector3(transform.position.x + 11, -3.75f, 0f) + new Vector3(7.96000004f, 0.430000007f, -0.0537057072f) - new Vector3(11.210413933f, -2.27163458f, 0f), Quaternion.identity);
        //}
    //}





    
}
