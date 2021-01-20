using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMail : MonoBehaviour
{
    public bool NewMailTriggerCheck = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Pode recolher NOVO CHIP");
        NewMailTriggerCheck = true;
    }

    private void OnTriggerExit(Collider other)
    {
        NewMailTriggerCheck = false;
    }
}
