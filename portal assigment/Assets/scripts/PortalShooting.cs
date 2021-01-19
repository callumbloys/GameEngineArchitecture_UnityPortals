using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalShooting : MonoBehaviour
{
    public GameObject Portal_1;
    public GameObject Portal_2;

    public AudioClip ShootSound, TeleportSound;

    GameObject mainCamera;

    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("left click");
            portalshoot(Portal_1);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("right click");
            portalshoot(Portal_2);
        }
    }

    private void SetupAudio()
    {

    }

    void portalshoot(GameObject portal)
    {
        int x = Screen.width / 2;
        int y = Screen.height / 2;
        Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            Quaternion hitObjectRotation = Quaternion.LookRotation(hit.normal);
            portal.transform.position = hit.point;
            portal.transform.rotation = hitObjectRotation;
        }
    }
}
