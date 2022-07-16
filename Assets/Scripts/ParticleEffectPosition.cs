using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectPosition : MonoBehaviour
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
            transform.position = DiverRepulsion.rb.position;
        }
    }
}
