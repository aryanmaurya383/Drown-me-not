using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByFalling : MonoBehaviour

{
    
   

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DiverRepulsion.Restart(DiverRepulsion.GameOverSFX);
            
        }

    }
}
