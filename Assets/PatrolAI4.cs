using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolAI4 : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
    public Transform pos3;
    public Transform pos4;
    public Transform pos5;
    public Transform pos6;
    public Transform pos7;
    public Transform pos8;
    public Transform pos9;
    public Transform pos10;
    public Transform pos11;
    public Transform pos12;
    public Transform pos13;




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
            case "h1":
                agent.SetDestination(pos2.position);
                break;
            case "h2":
                agent.SetDestination(pos3.position);
                break;
            case "h3":
                agent.SetDestination(pos4.position);
                break;
            case "h4":
                agent.SetDestination(pos5.position);
                break;
            case "h5":
                agent.SetDestination(pos6.position);
                break;
            case "h6":
                agent.SetDestination(pos7.position);
                break;
            case "h7":
                agent.SetDestination(pos8.position);
                break;
            case "h8":
                agent.SetDestination(pos9.position);
                break;

            case "h9":
                agent.SetDestination(pos10.position);
                break;

            case "h10":
                agent.SetDestination(pos11.position);
                break;
            case "h11":
                agent.SetDestination(pos12.position);
                break;
            case "h12":
                agent.SetDestination(pos13.position);
                break;
            case "h13":
                agent.SetDestination(pos1.position);
                break;

            default:
                Debug.Log("Something wrong with the bots on EmptyLoop");
                break;
        }

    }
}
