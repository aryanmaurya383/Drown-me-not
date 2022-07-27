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
        
        if (DiverRepulsion.rb && ( Mathf.Abs(DiverRepulsion.rb.position.x - DiverRepulsion.mouseWorldPosition.x)  < DiverRepulsion.radius.x && Mathf.Abs((DiverRepulsion.rb.position.y - Camera.main.ScreenToWorldPoint(Input.mousePosition).y) ) < DiverRepulsion.radius.y))
        {
            

            //barImage.fillAmount = 1f - Mathf.Abs(DiverRepulsion.mouseWorldPosition.x - DiverRepulsion.rb.position.x) / DiverRepulsion.radius.x;
            barImage.fillAmount =(float)1.2 * (1f - Mathf.Abs(DiverRepulsion.rb.position.x - DiverRepulsion.mouseWorldPosition.x)/DiverRepulsion.radius.x);
        }
        else
        {
            barImage.fillAmount = 0f;
        }
    }


}
