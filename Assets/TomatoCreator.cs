using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TomatoCreator : MonoBehaviour
{
    public static int totalNumber = 0;
    [SerializeField] GameObject fruitPrefab;
    [SerializeField] int dropCount = 3;
    [SerializeField] float spread = 0.7f;
    
    
    int countDown= 5;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
        
        StartCoroutine(Instantiator(fruitPrefab));
    }

    

    
    
    public IEnumerator Instantiator(GameObject fruit) 
    {
        while (countDown > 0 && totalNumber < 14)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("Time left: " + countDown + " seconds");
            countDown--;
        }
        if (countDown == 0)
        {
            


            Debug.Log("Fruits are ready!!!");
            while (dropCount > 0)
            {
                dropCount -= 1;
                totalNumber += 1;

                Vector3 position = transform.position;
                position.x += spread * UnityEngine.Random.value - spread / 2;
                position.z += spread * UnityEngine.Random.value - spread / 2;
                position.y = 1f;
                GameObject tomato = Instantiate(fruit);
                tomato.transform.position = position;
            }
            
            //count and reduce the total number of tomatoes when collect it
            
            
            countDown = 5;
        }
    }


}
