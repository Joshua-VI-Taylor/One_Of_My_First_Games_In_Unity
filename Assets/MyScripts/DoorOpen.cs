using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{

    RaycastHit ray;
  
    public GameObject ActionTxt;
    public GameObject ActionKey;
    public Camera cam;
    public float range;
    public GameObject door;
    bool DO = true;

    void Start()
    {
        ActionKey.SetActive(false);
        ActionTxt.SetActive(false);

    }
    void Update()
    {

        if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out ray, range) && ray.transform.tag == "door")
        {
         
            ActionKey.SetActive(true);
            ActionTxt.GetComponent<Text>().text = "Open door";
            ActionTxt.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E)&&DO==false)
            {
                door.GetComponent<Animation>().Play("Door Open");
                DO = true;
               
            }
        }
        //else
        {
            ActionKey.SetActive(false);
            ActionTxt.SetActive(false);
        }
    }
}


