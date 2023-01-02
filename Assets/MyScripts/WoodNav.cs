 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class WoodNav : MonoBehaviour

{
    [SerializeField] private NavMeshAgent navM;
    [SerializeField] private Transform movePositionTransform;
    [SerializeField] private Transform movePositionTransform1;
    public void Awake()
    {
        navM = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        navM.destination = movePositionTransform.position;
    }
}

