using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TomatoCreator : MonoBehaviour
{
    public static int totalNumber = 0;
    [SerializeField] GameObject tomatoPrefab;
    [SerializeField] int dropCount = 3;
    [SerializeField] float spread = 0.7f;
    bool isCoroutineOver = true;
    
    
    int countDown= 5;
    
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Instantiator(tomatoPrefab));
    }

    
    private void Update()
    {
        if (countDown > 0 && totalNumber - MoveObject.fruitNumber < 14 && isCoroutineOver == true)
        {
            StartCoroutine(Instantiator(tomatoPrefab));
            return;  //to avoid the reduce countdown every frame
        }
        Debug.Log("Total number:" + totalNumber);  
         
    }
    
    
    public IEnumerator Instantiator(GameObject fruit) 
    {
        isCoroutineOver = false;
        while (countDown > 0 && totalNumber - MoveObject.fruitNumber < 14)
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
            
            
            
            
            countDown = 5;
            
        }
        isCoroutineOver = true;
        
    }


}
