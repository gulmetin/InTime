using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float baseSpeed = 12f;
    public float gravity = -9.81f;
    Vector3 velocity;
    void Update()
    {
        float x = Input.GetAxis("Horizontal1");
        float z = Input.GetAxis("Vertical1");
        
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * baseSpeed * Time.deltaTime);
        
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
