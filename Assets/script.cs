using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
// {
//     public class generating : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public Transform GameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.position == new Vector3(12.04f,0.00f,0.00f))
        {
            randX = 14.00f;
            //Random.Range(14.00f, 18.00f);
            whereToSpawn = new Vector2(randX, transform.position.y);
        Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
