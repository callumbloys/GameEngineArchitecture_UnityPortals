using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupobject : MonoBehaviour
{
    GameObject mainCamera;
    GameObject carriedObject;
    bool carrying;
    public float distance;
    public float smooth;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");

    }

    // Update is called once per frame
    void Update()
    {
        if(carrying)
        {
            carry(carriedObject);
            checkDrop();
            //rotateObject();
        }

        else
        {
            pickup();
        }
    }

    void carry(GameObject o)
    {
        o.transform.position = Vector3.Lerp(o.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
        o.transform.rotation = Quaternion.identity;
    }
    
    void pickup()
    {
        if(Input.GetKeyDown (KeyCode.E))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;

            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                pickupable p = hit.collider.GetComponent<pickupable>();

                if(p != null)
                {
                    carrying = true;
                    carriedObject = p.gameObject;
                    //p.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                    p.gameObject.GetComponent<Rigidbody>().useGravity = false;
                }
            }
        }

    }

    void checkDrop()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            dropObject();
        }
    }

    void dropObject()
    {
        carrying = false;
        //carriedObject.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        carriedObject.gameObject.GetComponent<Rigidbody>().useGravity = true;
        carriedObject = null;
    }

   /* void rotateObject()
    {
        carriedObject.transform.Rotate(0.1f, 0.2f, 0.3f);
    }*/
}
