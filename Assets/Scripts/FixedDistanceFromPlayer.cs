using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedDistanceFromPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DiverRepulsion.rb)
        {
            transform.position = new Vector3(DiverRepulsion.rb.position.x + 20f, -4.8f, 0);
        }
    }
}
