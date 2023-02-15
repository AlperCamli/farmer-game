using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoCreator : MonoBehaviour
{
    
    [SerializeField] public GameObject fruitPrefab;
    
    bool isFruit;
    int countDown= 10;

    // Start is called before the first frame update
    void Start()
    {
        isFruit = false;
        StartCoroutine(Instantiator(fruitPrefab));
    }

    // Update is called once per frame
    
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
            Instantiate(fruit, gameObject.transform.position, Quaternion.identity);
            isFruit = true;
            countDown = 10;
        }
    }


}
