using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public float speedH = 2.0f;
    public float speedV = 2.0f;
    public GameObject thisG;

    public float yaw;
    public float pitch;
    

    void Start ()
    {
        yaw = this.gameObject.transform.rotation.eulerAngles.x;
        pitch = this.gameObject.transform.rotation.eulerAngles.y;
	}
	
	
	void Update ()
    {
        if (Input.GetMouseButton(1))
        {
            yaw += speedH * Input.GetAxis("Mouse Y");
            pitch -= speedV * Input.GetAxis("Mouse X");
            

            transform.eulerAngles = new Vector3(yaw, pitch,0.0f);
            
        }
    }
}

