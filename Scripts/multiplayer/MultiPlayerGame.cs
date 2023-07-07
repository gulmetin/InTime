using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Random;
using System;
using UnityEngine.SceneManagement;

public class MultiPlayerGame : MonoBehaviour
{
    public static int row_int=4, column_int=4;

    public static void EasyGame(){
        row_int= UnityEngine.Random.Range(4,8+1);
        column_int= UnityEngine.Random.Range(4,8+1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);

    }
    
    public static void MediumGame(){
        row_int= UnityEngine.Random.Range(9,12+1);
        column_int= UnityEngine.Random.Range(9,12+1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
    
    public static void HardGame(){
        row_int= UnityEngine.Random.Range(13,15+1);
        column_int= UnityEngine.Random.Range(13,15+1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

}
