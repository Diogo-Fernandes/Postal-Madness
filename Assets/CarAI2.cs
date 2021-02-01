using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarAI2 : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;



    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "d1":
                agent.SetDestination(pos4.position);
                break;
            case "d2":
                agent.SetDestination(pos1.position);
                break;
            case "d3":
                agent.SetDestination(pos2.position);
                break;
            case "d4":
                agent.SetDestination(pos3.position);
                break;
            default:
                Debug.Log("Something wrong with the cars on LoopStreet");
                break;
        }

    }
}
