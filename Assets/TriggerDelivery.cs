using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
using UnityEngine.SceneManagement;

public class TriggerDelivery : MonoBehaviour
{

    public PickupController pickupController;
    public AudioSource tickDelivery;

    public GameObject uiObject;
    public GameObject uiObject2;
    public GameObject levelComplete;
    public ScoreScript scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        tickDelivery = GetComponent<AudioSource>();
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
        levelComplete.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(pickupController.equipped);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Chip")
        {
            Debug.Log("CHIP ENTREGUE" + scoreScript.ScoreValue);
            if (scoreScript.ScoreValue >= 4)
            {
                Time.timeScale = 0f;
                StartCoroutine("waitLevel");
            }
            else
            {
                scoreScript.ScoreValue++;

                pickupController.equipped = false;
                pickupController.fakeNews.enabled = false;

                //appear ui text entregue chip
                uiObject.SetActive(true);

                tickDelivery.Play();
                CameraShaker.Instance.ShakeOnce(8f, 6f, .5f, 1f);
                StartCoroutine("waitDelete");
            }
            
        }

    }

    IEnumerator waitDelete()
        {
            yield return new WaitForSeconds(3);
            uiObject.SetActive(false);
            uiObject2.SetActive(true);
            yield return new WaitForSeconds(3);
            uiObject2.SetActive(false);

    }


    IEnumerator waitLevel()
    {
        levelComplete.SetActive(true);
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("StartMenu");

    }
}
