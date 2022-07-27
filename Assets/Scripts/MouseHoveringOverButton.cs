using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHoveringOverButton : MonoBehaviour
{
    public static bool isMouseOverButton;
    void Start()
    {
        isMouseOverButton = true;
    }

    // Update is called once per frame
    
    public void MouseIsOverButton()
    {
        isMouseOverButton = true;
    }
    public void MouseIsNotOverButton()
    {
        isMouseOverButton = false;
    }
}
