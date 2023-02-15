using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTriggerer : MonoBehaviour
{

    FruitPrefab fruiter;
    [SerializeField] public Slider slider;
    [SerializeField] SliderController sldierController;
    TomatoCreator tomato_creator;
    


    void Start() 
    {
        fruiter = tomato_creator.tomato.GetComponent<FruitPrefab>();
            
    }

    private void OnTriggerStay(Collider other)
    {
        if (slider.value >= 99f)
        {
            switch (other.gameObject.tag)
            {
                case "Market":
                    //code
                    break;
                case "TomatoPlant":
                    fruiter.MoveToTarget(this.transform);
                    sldierController.Execute();
                    
                    break;
                case "Coop":
                    //add chicken coop
                    break;




            }
        }
    }
}