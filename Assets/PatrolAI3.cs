using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolAI3 : MonoBehaviour
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


    private bool reverse;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        reverse = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        switch (other.tag)
        {
            case "g1":
                if (reverse)
                {
                    reverse = false;
                }
                agent.SetDestination(pos2.position);
                break;
            case "g2":
                if (reverse)
                {
                    agent.SetDestination(pos1.position);
                }
                else
                {
                    agent.SetDestination(pos3.position);
                }
                break;
            case "g3":
                if (reverse)
                {
                    agent.SetDestination(pos2.position);
                }
                else
                {
                    agent.SetDestination(pos4.position);
                }
                break;
            case "g4":
                if (reverse)
                {
                    agent.SetDestination(pos3.position);
                }
                else
                {
                    agent.SetDestination(pos5.position);
                }
                break;
            case "g5":
                if (reverse)
                {
                    agent.SetDestination(pos4.position);
                }
                else
                {
                    agent.SetDestination(pos6.position);
                }
                break;
            case "g6":
                if (reverse)
                {
                    agent.SetDestination(pos5.position);
                }
                else
                {
                    agent.SetDestination(pos7.position);
                }
                break;
            case "g7":
                if (reverse)
                {
                    agent.SetDestination(pos6.position);
                }
                else
                {
                    agent.SetDestination(pos8.position);
                }
                break;
            case "g8":
                if (reverse)
                {
                    agent.SetDestination(pos7.position);
                }
                else
                {
                    agent.SetDestination(pos9.position);
                }
                break;

            case "g9":
                if (!reverse)
                {
                    reverse = true;
                    agent.SetDestination(pos8.position);
                }
                
                break;


            default:
                Debug.Log("Something wrong with the bots on BigLoop");
                break;
        }

    }
}
