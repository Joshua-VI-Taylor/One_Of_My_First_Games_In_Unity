using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nav : MonoBehaviour
{
    [SerializeField] private UnityEngine.AI.NavMeshAgent Bot;
    [SerializeField] private Transform BotTarget;
    
    private void Awake()
    {
        Bot.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {

        Bot.destination = BotTarget.position;

    }
}
