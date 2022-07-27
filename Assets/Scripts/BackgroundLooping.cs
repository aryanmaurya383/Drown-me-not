using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLooping : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;

    private void Start()
    {
        backgroundSpeed = 0.1f;
    }
    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);   
    }
}
