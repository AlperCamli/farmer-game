using UnityEngine;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour
{
    Transform player;
    Transform market;
    [SerializeField] float speed = 5f;
    [SerializeField] float pickUpDistance = 3f;
    
    public static int fruitNumber = 0;
    
    private void Awake() 
    {
        player = GameManager.instance.player.transform;
        market = GameManager.instance.market.transform;
    }
    private void Update() 
    {
        fruitNumber = player.childCount - 3;
        Debug.Log("fruit number carried: " + fruitNumber);
        MoveToPlayer();
        
        
    }

    void MoveToPlayer() 
    {
        
        
        float distance_player = Vector3.Distance(transform.position, player.position);
        Debug.Log("Distance: "+ distance_player);
        if  (GameManager.instance.slider.value <= 99f || distance_player > pickUpDistance || fruitNumber >= 10)
        {
            return;
            
        }
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        if (distance_player < 0.1f) 
        {
            //add a UI tomato image all tomatoes will go there
            fruitNumber += 1;
            transform.parent = player;
            transform.localPosition = new Vector3 (0, fruitNumber / 10f, -1f);
            
        }
    }
    void MoveToMarket() 
    {
        float distance_market = Vector3.Distance(transform.position, market.position);
        Debug.Log("Distance: "+ distance_market);
        if  (GameManager.instance.slider.value <= 99f || distance_market > pickUpDistance || fruitNumber <= 0)
        {
            return;
            
        }
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        if (distance_market < 0.1f) 
        {
            //DESTROY TOMATOES AND GAIN MONEY
            fruitNumber += 1;
            transform.parent = player;
            transform.localPosition = new Vector3 (0, fruitNumber / 10f, -1f);
            
        }


    }
}
