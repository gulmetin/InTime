using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public int sumkeys;
    public Canvas LevelCompleteCanvas,MainCanvas;
    public TMP_Text TextField;
    void OnTriggerEnter(Collider collider){
        PlayerInventory playerInventory = collider.GetComponent<PlayerInventory>();

        if(playerInventory != null){
            if(playerInventory.NumberOfKeys == sumkeys){
                MainCanvas.gameObject.SetActive(false);
                LevelCompleteCanvas.gameObject.SetActive(true);

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else{
                TextField.text = "Your keys are missing!";
                StartCoroutine(DeleteText());
            }
        }
    }

    IEnumerator DeleteText(){
        yield return new WaitForSeconds (5f);
        TextField.text = " ";              
    }
}
