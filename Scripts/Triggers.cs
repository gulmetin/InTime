using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Triggers : MonoBehaviour
{
    public TMP_Text TextField;
    public string text;
    public bool once=false;

    void OnTriggerEnter(Collider collider){
       TextField.text = text;
       StartCoroutine(DeleteText());
    }

    IEnumerator DeleteText(){
        yield return new WaitForSeconds (5f);
        TextField.text = " ";
        if(once){
            Destroy(gameObject);
        }              
    }
}
