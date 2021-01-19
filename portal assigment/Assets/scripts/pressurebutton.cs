using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurebutton : MonoBehaviour
{

    public GameObject platform1;
    public GameObject platform2;
    public GameObject button;

    public Material[] material;
    Renderer rend;

    bool platformUp = false;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        button.transform.position += new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        /*if (col.gameObject.tag == "MoveableObject")
        {
            if (!platformUp)
            {
                rend.sharedMaterial = material[1];
                platformUp = true;
                platform1.transform.position += new Vector3(0, 6, 0);
                platform2.transform.position += new Vector3(0, 12, 0);
                button.transform.position += new Vector3(0, -0.16f, 0);
            }        
        }

        else if (col.gameObject.tag == "MoveableObject2")
        {
            if (!platformUp)
            {
                rend.sharedMaterial = material[1];
                platformUp = true;
                platform1.transform.position += new Vector3(0, 6, 0);
                platform2.transform.position += new Vector3(0, 12, 0);
                button.transform.position += new Vector3(0, -0.16f, 0);
            }
        }*/


        if (col.gameObject.tag == "MoveableObject" || col.gameObject.tag == "MoveableObject2")
        {
            if (!platformUp)
            {
                rend.sharedMaterial = material[1];
                platformUp = true;
                platform1.transform.position += new Vector3(0, 6, 0);
                platform2.transform.position += new Vector3(0, 12, 0);
                button.transform.position += new Vector3(0, -0.16f, 0);
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        /*if (col.gameObject.tag == "MoveableObject")
        {
            rend.sharedMaterial = material[2];
            platformUp = false;
            platform1.transform.position += new Vector3(0, -6, 0);
            platform2.transform.position += new Vector3(0, -12, 0);
            button.transform.position += new Vector3(0, +0.16f, 0);
        }

        else if (col.gameObject.tag == "MoveableObject2")
        {
            rend.sharedMaterial = material[2];
            platformUp = false;
            platform1.transform.position += new Vector3(0, -6, 0);
            platform2.transform.position += new Vector3(0, -12, 0);
            button.transform.position += new Vector3(0, +0.16f, 0);
        }*/

        if (col.gameObject.tag == "MoveableObject" || col.gameObject.tag == "MoveableObject2")
        {
            rend.sharedMaterial = material[2];
            platformUp = false;
            platform1.transform.position += new Vector3(0, -6, 0);
            platform2.transform.position += new Vector3(0, -12, 0);
            button.transform.position += new Vector3(0, +0.16f, 0);
        }


    }
}
