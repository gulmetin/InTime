using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TriggerManager : MonoBehaviour
{

    public GameObject obj1, obj2,obj3,obj4False;
    public TMP_Text TextField;
    public string text,inputKey;
    bool permission = false;
    PlayerInventory playerInventory;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider collider){
        playerInventory = collider.GetComponent<PlayerInventory>();
        TextField.text = text;
        permission=true;
    }

    void Update()
    {
        if(permission==true){
            if(Input.GetKey(inputKey)){
                TextField.text = text=  " ";
                if(obj1){
                    obj1.SetActive(false);
                }
                if(obj2.tag == "Water"){
                    playerInventory.WaterCollected();
                    Debug.Log(playerInventory.Water);
                    StartCoroutine(Wait());
                }else{
                    if(obj4False){
                        obj4False.SetActive(false);
                    } 
                }
                
                if(obj2){
                    obj2.SetActive(true);
                }
                if(obj3){
                    obj3.SetActive(true);
                }
                
            }
        }
    }

    void OnTriggerExit(Collider collider){
        TextField.text = " ";
        permission=false;
    }

    IEnumerator Wait(){
        yield return new WaitForSeconds (1f);
        TextField.text = " ";
        if(obj4False){
            obj4False.SetActive(false);
        }          
    }
}