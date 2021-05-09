using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        var vertical = Input.GetAxis("Vertical"); //w/s
        var horizontal = Input.GetAxis("Horizontal");
        var upDown = Input.GetKey(KeyCode.Space) ? 1 : Input.GetKey(KeyCode.LeftControl) ? -1 : 0;
        var verticalDelta = transform.forward * vertical * Speed * Time.deltaTime;
        var horizontalDelta = transform.right * horizontal * Speed * Time.deltaTime;
        var upDownDelta = transform.up * upDown * Speed * Time.deltaTime;
        var newPosition = transform.position + verticalDelta + horizontalDelta + upDownDelta;
        transform.position = newPosition;
    }
}
