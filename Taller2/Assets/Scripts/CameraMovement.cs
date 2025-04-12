using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;

    private float targetPositionX;
    public float smoothTime = 0.3F;

    private Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetPositionX = player.transform.position.x;
        transform.position = Vector3.SmoothDamp(transform.position,
            new Vector3(targetPositionX, transform.position.y, transform.position.z),
            ref velocity,
            smoothTime);
    }
}
