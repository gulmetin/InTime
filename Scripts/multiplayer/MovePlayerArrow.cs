using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerArrow : MonoBehaviour
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
        
        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        move = this.transform.TransformDirection(move);
        characterController.Move(move * speed);
        this.transform.Rotate(this.rotation);
    }
}
