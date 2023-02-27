using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    //create an empty object called game manager and add the script

    public static GameManager instance;
    public GameObject player; // assign the player
    public Slider slider;
    private void Awake() 
    {
        instance = this;
    }
    


}