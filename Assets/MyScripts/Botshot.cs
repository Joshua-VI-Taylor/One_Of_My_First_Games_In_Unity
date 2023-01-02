using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botshot : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] Camera Othercamera;
    public GameObject Bot;
    public float Range;
    public float Health = 100;
    public GameObject UIHealth;
    public Scene Jos;
    void Start()
    {
        UIHealth.GetComponent<UnityEngine.UI.Text>().text = "Health " + Health.ToString();
        Othercamera.enabled = false;
    }

    RaycastHit rayy;
    void Update()
    {

        if (Physics.Raycast(Bot.transform.position, Bot.transform.TransformDirection(Vector3.forward), out rayy, Range) && rayy.transform.tag == "enemy")
        {
            Health -= 0.01f;
        }

        UIHealth.GetComponent<UnityEngine.UI.Text>().text = "Health " + Health.ToString();

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * Range, Color.green);

        if (Health <= 0)
        {
            Othercamera.enabled = true;
            Destroy(GameObject.Find("First Person Controller Minimal"));

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Destroy")
        {
            Health = 0;
            
        }
    }
  
}

