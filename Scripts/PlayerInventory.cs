using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfKeys {get;private set;}
    public bool Water {get;private set;}
    //Water = false;

    public void KeysCollected()
    {
        NumberOfKeys++;
    }
    public void WaterCollected()
    {
        Water = true;
    }
}