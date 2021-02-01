using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrolAI5 : MonoBehaviour
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
            case "i1":
                agent.SetDestination(pos2.position);
                break;
            case "i2":
                agent.SetDestination(pos3.position);
                break;
            case "i3":
                agent.SetDestination(pos4.position);
                break;
            case "i4":
                agent.SetDestination(pos5.position);
                break;
            case "i5":
                agent.SetDestination(pos6.position);
                break;
            case "i6":
                agent.SetDestination(pos7.position);
                break;
            case "i7":
                agent.SetDestination(pos8.position);
                break;
            case "i8":
                agent.SetDestination(pos9.position);
                break;

            case "i9":
                agent.SetDestination(pos1.position);
                break;

            default:
                Debug.Log("Something wrong with the bots on EmptyLoop");
                break;
        }

    }
}
