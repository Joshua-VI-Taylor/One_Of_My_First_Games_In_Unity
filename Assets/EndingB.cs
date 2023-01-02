using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingB : MonoBehaviour
{
    //BotDest & Bot
    public StartingB SB;
    
    [SerializeField] private Animator CreatAnim;
    [SerializeField] private List<int> tIMER;
    [SerializeField] private string[] RTags;
    [SerializeField] private GameObject[] Pre;
    public GameObject This;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.tag == RTags[0])
        {
            //CreatAnim.Play();
            StartCoroutine(TC());
        }

        if (collision.collider.gameObject.tag == RTags[1])
        {
            SB.TheRobot.destination = SB.RobotTarget1[0].position;
            CreatAnim.SetBool("Isopen", !true);
        }
    }
    IEnumerator TC()
    {
        yield return new WaitForSeconds(1);
        Pre[0] = GameObject.Find("A");
        Pre[1] = GameObject.Find("B");
        Pre[2] = GameObject.Find("C");
        Pre[0].AddComponent<Rigidbody>();
        Pre[1].AddComponent<Rigidbody>();
        Pre[2].AddComponent<Rigidbody>();
        Pre[0].transform.parent = null;
        Pre[1].transform.parent = null;
        Pre[2].transform.parent = null;
        Destroy(Pre[0], 27);
        Destroy(Pre[1], 27);
        Destroy(Pre[2], 27);
       
        yield return new WaitForSeconds(2);
        CreatAnim.SetBool("Isopen", true);
      
        yield return new WaitForSeconds(3);
        SB.TheRobot.gameObject.tag = "Robot";
        This.gameObject.SetActive(false);
    }
    
}
