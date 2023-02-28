using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabbageCreator : MonoBehaviour
{
    int countDown= 5;
    float scaleBooster = 0.2f;
    Vector3 scaleChange;
    bool isThereCabbage = false;
    
    [SerializeField] GameObject cabagePrefab;

private void Start() {
    scaleChange = new Vector3 (1f,1f,1f);
    
}
private void Update() 
{
    if (!isThereCabbage) 
    {
        StartCoroutine(Instantiator(cabagePrefab));
        return;
    }
}


    public IEnumerator Instantiator(GameObject fruit) 
    {
        GameObject cabbage = Instantiate(fruit, transform.position, Quaternion.identity);
        while (countDown > 0)
        {
            
            
            yield return new WaitForSeconds(1f); //grow cabbages
            cabbage.transform.localScale += scaleChange * scaleBooster;
            Debug.Log("Time left for cabbages : " + countDown + " seconds");
            countDown--;
        }
        
            Debug.Log("Cabbages are ready!!!");
        while (!isThereCabbage)
        {
            
            countDown = 5;
            
        }
    }   


}
