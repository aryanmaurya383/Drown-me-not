using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;
    public static Transform cameraPosition;
    // Update is called once per frame
    private void Start()
    {
        cameraPosition = this.transform;
        cameraSpeed = 1f;
    }
    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
