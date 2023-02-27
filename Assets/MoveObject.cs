using UnityEngine;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour
{
    Transform player;
    [SerializeField] float speed = 5f;
    [SerializeField] float pickUpDistance = 1.5f;
    
    float fruitNumber;
    
    private void Awake() 
    {
        player = GameManager.instance.player.transform;
    }
    private void Update() 
    {
        float distance = Vector3.Distance(transform.position, player.position);
    
        if  (GameManager.instance.slider.value <= 99f && distance > pickUpDistance && fruitNumber >= 10f)
        {
            return;
            
        }
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        if (distance < 0.1f) 
        {
            //add a UI tomato image all tomatoes will go there
            fruitNumber += 1f;
            transform.parent = player;
            transform.localPosition = new Vector3 (0, fruitNumber / 10f, -1f);
            TomatoCreator.totalNumber -= 1;
        }
        
    }
}

