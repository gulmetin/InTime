using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerWasd : MonoBehaviour
{
    public int speed = 30;
    public float _rotationSpeed = 180;
    public CharacterController characterController;

    void Update()
    {
        MoveCharacter();
    }

    Vector3 rotation;
    private void MoveCharacter()
    {
        
        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal1") * _rotationSpeed * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical1") * Time.deltaTime);
        move = this.transform.TransformDirection(move);
        characterController.Move(move * speed);
        this.transform.Rotate(this.rotation);

    }
}
