using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Transform PlayerCamera;
    public Transform Portal_A;
    public Transform Portal_B;

    void Update()
    {
        Vector3 playerOffsetFromPortal = PlayerCamera.position - Portal_B.position;
        transform.position = Portal_A.position + playerOffsetFromPortal;

      /*  float angularDiffenceBetweenPortalRotations = Quaternion.Angle(Portal_A.rotation, Portal_B.rotation);
        Quaternion Portal_ARotationalDifference = Quaternion.AngleAxis(angularDiffenceBetweenPortalRotations, Vector3.up);
        Vector3 newCameraDirection = Portal_ARotationalDifference * PlayerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);*/
    }
}
 