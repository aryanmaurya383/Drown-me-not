using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stone : MonoBehaviour
{
    public  Transform fireposition;
    public GameObject projectile;
    private Vector3 vectorAtRight;
    private Vector3 vectorAtLeft;
    
    

    // Start is called before the first frame update
    


    // Update is called once per frame
    void Update()
    {
        if (DiverRepulsion.rb)
        {
            vectorAtRight.x = DiverRepulsion.rb.position.x + (float)1.2;
            vectorAtRight.y = DiverRepulsion.rb.position.y;
            vectorAtRight.z = 0;
            vectorAtLeft.x = DiverRepulsion.rb.position.x - (float)1.2;
            vectorAtLeft.y = DiverRepulsion.rb.position.y;
            vectorAtLeft.z = 0;
        }
        


        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(projectile, fireposition.position , fireposition.rotation);

        }
        if ( DiverRepulsion.mouseWorldPosition.x > DiverRepulsion.rb.transform.position.x)
        {
            fireposition.position = vectorAtRight;
        
        }
        else
        {
            fireposition.position = vectorAtLeft;
    
        }
    }
}