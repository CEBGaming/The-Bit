using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float UpFront;

    //[SerializeField] private Transform Marino;
    //[SerializeField] private float DistFront = 2f;
    //[SerializeField] private float SpeedCam = 0.5f;

    //[SerializeField] private float smoothing;

    void LateUpdate()
    {
        //this.transform.position = new Vector3(target.position.x + UpFront, target.position.y, this.transform.position.z);

        this.transform.position = new Vector3(target.position.x, target.position.y + 3, this.transform.position.z);
        
        //transform.position = new Vector3(Marino.position.x + UpFront, transform.position.y, transform.position.z);
        ///UpFront = Mathf.Lerp(UpFront, (DistFront * Marino.localScale.x), Time.deltaTime * SpeedCam);


        //if(transform.position != target.position)
        //{
        // Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
        // transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);

        // }
    }
}
