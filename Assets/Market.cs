using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Market : MonoBehaviour
{
     [SerializeField] SliderController sliderController;
    
    void Start() 
    {
        sliderController = FindObjectOfType<SliderController>();
    }
    

    private void OnTriggerStay(Collider other) 
    {
           if (sliderController.slider.value >= 100) 
           {
            sliderController.Execute();
           }
           
    }
    
    
}
