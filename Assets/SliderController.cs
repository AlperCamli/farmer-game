using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    //IEnumerator just delays gaining money
    

    [SerializeField] public Slider slider;
    [SerializeField] float sliderTime;
    [SerializeField] GameObject sliderObject;
    bool isLoading;
    

    void Start()
    {
        sliderObject.SetActive(false);
        isLoading = false;
        
    }
    void Update() 
    {
        slider.value = Mathf.Clamp(slider.value, 0f, 100f);
        Debug.Log(isLoading);
        if (!isLoading && slider.value > 0f) 
        {
            slider.value -= Time.deltaTime * 100f / (sliderTime / 1.5f);
            
            
        } 
        else if (!isLoading && slider.value == 0f) 
        {
            sliderObject.SetActive(false);
        }
        
    }
    private void OnTriggerStay(Collider other) 
    {
           CirculerSliderUp();
           
    }
    private void OnTriggerExit(Collider other) 
    {
        CirculerSliderDown();
    }
    
    public void CirculerSliderUp() 
    {
        sliderObject.SetActive(true);
        isLoading = true;
        slider.value += Time.deltaTime * 100f / sliderTime;

    }
    public void CirculerSliderDown() 
    {
        isLoading = false;
        
        
        
    }
    
    public void Execute() 
    {

        
    }

}

