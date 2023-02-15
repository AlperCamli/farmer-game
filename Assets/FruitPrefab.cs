using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitPrefab : MonoBehaviour
{

    [SerializeField] public float speed = 1f; // The speed at which the object moves



    public void MoveToTarget(Transform target)
    {


        // Calculate the new position of the object
        Vector3 newPosition = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);

        // Update the position of the object
        transform.position = newPosition;
    }
}

