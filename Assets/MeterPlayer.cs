using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeterPlayer : MonoBehaviour
{
    public float maxTime = 24;
    public float currentTime;

    public MeterScript meterScript;

    private float timedebug;
    private float fillTime =0f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 8;
    }

    // Update is called once per frame
    void Update()
    {
        timedebug = Mathf.Lerp(currentTime, maxTime, fillTime);
        fillTime += 0.0055f * Time.deltaTime;


        if (timedebug == 24)
        {
            Debug.Log("CHEGOU");
        }
        else
        {
            meterScript.SetTime(timedebug);
        }
        Debug.Log(timedebug);
    }
}
