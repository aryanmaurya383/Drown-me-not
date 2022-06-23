using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Animator rand = GetComponent<Animator>() ;
       rand.Play("CoinRotation", 0 , Random.Range (0.0f , 2.0f)) ;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
