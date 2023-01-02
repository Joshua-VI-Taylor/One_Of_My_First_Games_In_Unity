using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ok : MonoBehaviour
{
    public GameObject Board;
    public GameObject NextB;
    public GameObject BText;
    int Number = 0;
    public GameObject Player;
    public GameObject Cam;
    public GameObject otherCam;
    public bool ond;
    
    private void Start()
    {
        Board.SetActive(false);
        NextB.SetActive(false);
        BText.SetActive(false);
        ond = false;
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "End")
        {
            Board.SetActive(true);
            NextB.SetActive(true);
            BText.SetActive(true);
            Player.GetComponent<FirstPersonMovement>().enabled = false;
            Player.GetComponent<Jump>().enabled = false;
            Player.GetComponent<Crouch>().enabled = false;
            Cam.GetComponent<FirstPersonLook>().enabled = false;
            Cam.SetActive(false);
            Player.SetActive(false);
            otherCam.SetActive(true);
            
            
        }
  
    }

    public void Update()
    {
        if(Number == 0)
        {
        BText.GetComponent<UnityEngine.UI.Text>().text = "{Factor owner}, please don't kill me";
        }
        if(Number == 1)
        {
            BText.GetComponent<UnityEngine.UI.Text>().text = "{Me}, I didn't come here to stop your progess I came help you recycle";
        }
        if(Number == 2)
        {
            BText.GetComponent<UnityEngine.UI.Text>().text = "{Factor owner}, Now I understand, I'll start recycling";
        }
       
        if(Number==3)
        {
            NextB.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Number++;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Number--;
        }
        if (Number <=0 )
        {
            Number = 0;
        }
        else if (Number >= 4)
        {
            Number = 4;
        }
       
    }
    public void talk()
    {
        Number++;
       
    }
}       
       
    

