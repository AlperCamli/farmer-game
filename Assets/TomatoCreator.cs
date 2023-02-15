using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TomatoCreator : MonoBehaviour
{
    
    [SerializeField] public GameObject fruitPrefab;
    [SerializeField] public Transform tomatoParent;
    [SerializeField] Slider slider;
    [SerializeField] GameObject player;
    FruitPrefab fruiter;
    
    bool isFruit;
    int countDown= 5;
    
    public GameObject tomato;

    // Start is called before the first frame update
    void Start()
    {
        fruiter = tomato.GetComponent<FruitPrefab>();
        isFruit = false;
        StartCoroutine(Instantiator(fruitPrefab));
    }

    void OnTriggerExit(Collider other)
    {
        if (slider.value >= 99f) 
        {
            fruiter.MoveToTarget(player.transform);
        }
    }

    
    
    IEnumerator Instantiator(GameObject fruit) 
    {
        while (countDown > 0 && !isFruit)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Time left: " + countDown + " seconds");
            countDown--;
        }
        if (countDown == 0)
        {
            
            Debug.Log("Fruits are ready!!!");           
            tomato = Instantiate(fruit, gameObject.transform.position, Quaternion.identity);
            tomato.transform.parent = tomatoParent;
            tomato.transform.localPosition = new Vector3(transform.localPosition.x , -tomatoParent.position.y + transform.localPosition.y + 1f, transform.localPosition.z);
            
            
            isFruit = true;
            countDown = 5;
        }
    }


}
