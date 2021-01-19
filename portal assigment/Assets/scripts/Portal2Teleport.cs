using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal2Teleport : MonoBehaviour
{
    public GameObject otherPortal;
    public GameObject Player;
    public GameObject pickupableObject;
    public GameObject pickupableObject2;

    void Start()
    {

    }


    void Update()
    {

    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");

        if (other.tag == "Player")
        {
            Debug.Log("you hit the portal");

            other.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 1.2f;
            //other.transform.rotation = other.transform.rotation;
            Player.transform.rotation = otherPortal.transform.rotation;

            //other.transform.position = new Vector3();
        }

        if (other.tag == "MoveableObject")
        {
            Debug.Log("box hit the portal");

            pickupableObject.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 1.2f;
            //other.transform.rotation = other.transform.rotation;
            pickupableObject.transform.rotation = otherPortal.transform.rotation;

            //other.transform.position = new Vector3();
        }

        if (other.tag == "MoveableObject2")
        {
            Debug.Log("box 2 hit the portal");

            pickupableObject2.transform.position = otherPortal.transform.position + otherPortal.transform.forward * 1.2f;
            //other.transform.rotation = other.transform.rotation;
            pickupableObject2.transform.rotation = otherPortal.transform.rotation;

            //other.transform.position = new Vector3();
        }
    }
    

}


