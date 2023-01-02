using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotDoorAction : MonoBehaviour
{
    RaycastHit doorhit;
    public Transform Bot;
  
    [Header("MaxDistance you can open or close the door.")]
    public float MaxDistance = 6;
    [SerializeField] private LayerMask door;
    private bool opened = false;
    public Animator anim;
   
  private void Start()
    {
       
    }
    void Update()
    {
        //This will tell if the player press F on the Keyboard. P.S. You can change the key if you want.
        if (Physics.Raycast(Bot.transform.position, Bot.transform.forward, out doorhit, MaxDistance))
        {
           
       
                rayd();
         
               
            
        }

        void rayd()
        {
            //This will name the Raycasthit and came information of which object the raycast hit.



            // if raycast hits, then it checks if it hit an object with the tag Door.
            if (doorhit.transform.tag == "door")
            {

                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                anim = doorhit.transform.GetComponentInParent<Animator>();

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
            yield return new WaitForSeconds(8f);
            anim.SetBool("Opened", opened);
        }
    }
}
