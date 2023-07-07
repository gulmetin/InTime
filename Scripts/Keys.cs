using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Keys: MonoBehaviour
{
    void Start(){
        playerInventory = gameObject.GetComponent<PlayerInventory>();
    }
    public TMP_Text TextField;
    public TMP_Text Counter;
    PlayerInventory playerInventory;
    public Image Point;
    public float Distance;

    void Update(){
        Vector3 GoForward = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;    

        if(Physics.Raycast(transform.position,GoForward,out hit)){
            if(hit.distance <= Distance && hit.collider.gameObject.tag == "Keys"){
                Point.gameObject.SetActive(true);
                if(Input.GetMouseButtonDown(0)){
                    playerInventory.KeysCollected();
                    hit.collider.gameObject.SetActive(false);
                    Point.gameObject.SetActive(false);
                    Counter.text = ""+playerInventory.NumberOfKeys;
                    TextField.text = "Key received.";
                    StartCoroutine(DeleteText());
                    
                }
            }
        }
    }

    IEnumerator DeleteText(){
        yield return new WaitForSeconds (5f);
        TextField.text = " ";              
    }
 
}
