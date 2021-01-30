using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolAI : MonoBehaviour
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
        /*if (other.tag == "q1")
        {
            agent.SetDestination(pos2.position);
        }
        if (other.tag == "q2")
        {
            agent.SetDestination(pos1.position);
        }
        
        if (other.tag == "q3")
        {
            agent.SetDestination(pos4.position);
        }
        if (other.tag == "q4")
        {
            agent.SetDestination(pos1.position);
        }*/

        switch (other.tag)
        {
            case "q1":
                agent.SetDestination(pos2.position);
                break;
            case "q2":
                agent.SetDestination(pos3.position);
                break;
            case "q3":
                agent.SetDestination(pos4.position);
                break;
            case "q4":
                agent.SetDestination(pos5.position);
                break;
            case "q5":
                agent.SetDestination(pos6.position);
                break;
            case "q6":
                agent.SetDestination(pos7.position);
                break;
            case "q7":
                agent.SetDestination(pos8.position);
                break;

            case "q8":
                agent.SetDestination(pos9.position);
                break;

            case "q9":
                agent.SetDestination(pos10.position);
                break;

            case "q10":
                agent.SetDestination(pos11.position);
                break;
            case "q11":
                agent.SetDestination(pos12.position);
                break;
            case "q12":
                agent.SetDestination(pos13.position);
                break;
            case "q13":
                agent.SetDestination(pos1.position);
                break;

            default:
                Debug.Log("Something wrong with the bots on Quarter1");
                break;
        }

    }
}
