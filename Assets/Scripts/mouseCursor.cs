using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCursor : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite leftClickCursor;
    public Sprite normalCursor;
    public float timeBtwSpawn;
    public GameObject clickEffect;
    public GameObject trailEffect;

    public bool fishFacingLeft;
    private void Start()

    {
        fishFacingLeft = true;
        Cursor.visible = false;
        timeBtwSpawn = 0.1f;
        rend = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        transform.position = cursorPos;
        if (DiverRepulsion.diverFacingRight && !fishFacingLeft)
        {
            transform.Rotate(0f, 180f, 0f);
            fishFacingLeft = true;
        }
        else if(!DiverRepulsion.diverFacingRight && fishFacingLeft)
        {
            transform.Rotate(0f, 180f, 0f);
            fishFacingLeft = false;
        }

        if (Input.GetMouseButton(0))
        {
            rend.sprite = leftClickCursor;
            Instantiate(clickEffect, transform.position, Quaternion.identity);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            rend.sprite = normalCursor;
        }

        if (timeBtwSpawn <= 0)
        {
            Instantiate(trailEffect, cursorPos, Quaternion.identity);
            timeBtwSpawn = 0.1f;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
