using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    private Image barImage;

    

    private void Awake()
    {
        barImage = transform.Find("Bar").Find("border").Find("background").Find("bar").GetComponent<Image>();
        
        barImage.fillAmount = 0f;
        
    }

    void Update()
    {
        
        if (Mathf.Abs(SquareRepulsion.rb.position.x - SquareRepulsion.mouseWorldPosition.x)  < SquareRepulsion.radius.x && Mathf.Abs((SquareRepulsion.rb.position.y - Camera.main.ScreenToWorldPoint(Input.mousePosition).y) ) < SquareRepulsion.radius.y)
        {
            

            //barImage.fillAmount = 1f - Mathf.Abs(SquareRepulsion.mouseWorldPosition.x - SquareRepulsion.rb.position.x) / SquareRepulsion.radius.x;
            barImage.fillAmount =(float)1.2 * (1f - Mathf.Abs(SquareRepulsion.rb.position.x - SquareRepulsion.mouseWorldPosition.x)/SquareRepulsion.radius.x);
        }
        else
        {
            barImage.fillAmount = 0f;
        }
    }


}
