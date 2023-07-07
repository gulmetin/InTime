using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    public TMP_Text TextField;
    public Canvas MainCanvas,GameOverCanvas,LevelCompleteCanvas;

    // Update is called once per frame
    void Update()
    {
        if(!LevelCompleteCanvas.gameObject.activeSelf)
        {
            time -= Time.deltaTime;
            TextField.text = ""+ (int) time;
            if(time<=0){
                MainCanvas.gameObject.SetActive(false);
                GameOverCanvas.gameObject.SetActive(true);

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}
