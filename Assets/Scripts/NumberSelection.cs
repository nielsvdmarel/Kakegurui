using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberSelection : MonoBehaviour {
    [SerializeField]
    private GameObject[] Greenards;
    
    public GameObject[] RedCards;

    public GameObject SelectedRedCard;
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Mouse is down");

            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
                Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                if (hitInfo.transform.gameObject.tag == "Redcard")
                {
                    SelectedRedCard = hitInfo.transform.gameObject;
                }
                else {
                    //Debug.Log("nopz");
                }
            }
            else {
                //Debug.Log("No hit");
            }
           //Debug.Log("Mouse is down");
        }
    }
}

