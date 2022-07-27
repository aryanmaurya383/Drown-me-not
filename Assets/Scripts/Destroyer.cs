using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private float timePassed;
    private void Start()
    {
        timePassed = 0;
    }
    private void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > 60)
        {
            timePassed = 0;
            Destroy(this.gameObject);
        }
    }

}

