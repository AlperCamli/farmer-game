using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTriggerer : MonoBehaviour
{
    
    [SerializeField] FruitPrefab fruiter;
    [SerializeField] public Slider slider;




    private void OnTriggerStay(Collider other)
    {
        if (slider.value >= 100)
        {
            switch (other.gameObject.tag)
            {
                case "Market":
                    //code
                    break;
                case "TomatoPlant":
                    fruiter.MoveToTarget(this.transform);
                    break;
                case "Coop":
                    //add chicken coop
                    break;




            }
        }
    }
}
