using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActions : MonoBehaviour
{
    RaycastHit doorhit;
  
    public Transform Player;
    [Header("MaxDistance you can open or close the door.")]
    public float MaxDistance = 6;
    [SerializeField] private LayerMask door;
    [SerializeField] private LayerMask KeyLayer;
    private bool opened = false;
    public  Animator anim;
    [SerializeField] private GameObject actionTxt;
    [SerializeField] private GameObject actionKey;
    [SerializeField] private GameObject Key;
    [SerializeField] private GameObject Dest;
    [SerializeField] bool Haskey = false;
    
    private void Start()
    {
        
    }
    void Update()
    {
        if (Physics.Raycast(Player.transform.position, Player.transform.forward, out doorhit, MaxDistance+2f, KeyLayer)&& Haskey == false)
        {
            actionKey.SetActive(true);
            actionTxt. GetComponent<UnityEngine.UI.Text>().text = "Pick up Key";
            actionTxt.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Haskey = true;
               Key.transform.rotation = Dest.transform.rotation;
               Key.transform.position = Dest.transform.position;
               Key.transform.parent = Dest.transform;
               Key.GetComponent<Rigidbody>().isKinematic = true;
               Key.GetComponent<Rigidbody>().useGravity = false;
            }
        }
            //This will tell if the player press F on the Keyboard. P.S. You can change the key if you want.
            if (Physics.Raycast(Player.transform.position, Player.transform.forward, out doorhit, MaxDistance, door)&&Haskey ==true)
        {
            actionKey.SetActive(true);
            actionTxt.GetComponent<UnityEngine.UI.Text>().text = "Open door";
            actionTxt.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {

                Pressed();
                //Delete if you dont want Text in the Console saying that You Press E.
                Debug.Log("You Press E");
            }
    }
            else if  (Physics.Raycast(Player.transform.position, Player.transform.forward, out doorhit, MaxDistance, door) && Haskey == !true)
        {
            actionTxt.GetComponent<UnityEngine.UI.Text>().text = "Need a Key card";
            actionTxt.SetActive(true);
        }

                void Pressed()
    {
        //This will name the Raycasthit and came information of which object the raycast hit.
        

     
            // if raycast hits, then it checks if it hit an object with the tag Door.
            if (doorhit.transform.tag == "door")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                //anim = doorhit.transform.GetComponentInParent<Animator>();
                anim.GetComponent<Animator>();
                //This will set the bool the opposite of what it is.
                //opened = !opened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("Opened", !opened);
                //StartCoroutine(reset());
                StartCoroutine(Jo());
            }
        }

      IEnumerator Jo()
        {
            yield return new WaitForSeconds(4f);
            anim.SetBool("Opened", opened);
        }
    }
}

