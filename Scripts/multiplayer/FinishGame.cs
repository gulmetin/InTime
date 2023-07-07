using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FinishGame : MonoBehaviour
{
    public Canvas finishcanvas;
    public TMP_Text TextField;

    void OnTriggerEnter(Collider collider){
        if(collider.tag=="Finish"){
            finishcanvas.gameObject.SetActive(true);
            TextField.text =gameObject.name;
        }
    }
}
