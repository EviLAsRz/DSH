using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    public GameObject transformedObject;
    private void OnTriggerEnter(Collider other)
    {
        //Create a new game object an set the position and rotation to match the collided object
        GameObject newObject = Instantiate(transformedObject, other.transform.position, other.transform.rotation);
        //Set both collided object to false
        gameObject.SetActive(false);
        other.gameObject.SetActive(false);
        //Active the new object
        newObject.SetActive(true);

        Debug.Log("Collision detected between " + gameObject.name + " and " + other.gameObject.name);

    }
}
