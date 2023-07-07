using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    public Transform port;
    public GameObject player;
    // Update is called once per frame

    void OnTriggerEnter(Collider collider){
        player.transform.position = port.position;    
    }
}
