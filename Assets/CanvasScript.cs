using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{

    public static bool ObjectiveWindowDown = true;
    public GameObject ObjectiveMenuBig;
    public GameObject ObjectiveMenuSmall;

    // Start is called before the first frame update
    void Start()
    {
        ObjectiveMenuBig.SetActive(true);
        ObjectiveMenuSmall.SetActive(false);
        ObjectiveWindowDown = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (ObjectiveWindowDown)
            {
                Close();
            } else
            {
                Open();
            }
        }
    }

    void Open()
    {
        ObjectiveMenuSmall.SetActive(false);
        ObjectiveMenuBig.SetActive(true);
        ObjectiveWindowDown = true;
    }

    void Close()
    {
        ObjectiveMenuBig.SetActive(false);
        ObjectiveMenuSmall.SetActive(true);
        ObjectiveWindowDown = false;
        
    }
}
