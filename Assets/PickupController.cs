using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour
{
    //public ProjectileGun gunScript;
    public Rigidbody rb;
    public BoxCollider coll;
    public Transform player, gunContainer, fpsCam;
    public MeshRenderer fakeNews;
    public MeshRenderer trueNews;
    public TriggerMail triggerMail;
    public Outline outline1;
    public GameObject box1;
    public Outline outline2;
    public GameObject box2;
    public Outline outline3;
    public GameObject box3;
    public Outline outline4;
    public GameObject box4;
    public Outline outline5;
    public GameObject box5;
    public Outline outline6;
    public GameObject box6;
    public Outline outline7;
    public GameObject box7;

    public float pickUpRange;
    public float dropForwardForce, dropUpwardForce;

    public bool equipped;
    public static bool slotFull;

    private Outline[] homeArray;
    private GameObject[] boxArray;
    private int rng;
    private AudioSource woosh;

    private void Start()
    {
        woosh = GetComponent<AudioSource>();

        homeArray = new Outline[] { outline1, outline2, outline3, outline4, outline5, outline6, outline7 };
        boxArray = new GameObject[] { box1, box2, box3, box4, box5, box6, box7 };

        for(int i = 0; i< homeArray.Length; i++)
        {
            homeArray[i].enabled = false;
            boxArray[i].SetActive(false);
          
        }
        rng = Random.Range(0, homeArray.Length);
        homeArray[rng].enabled = true;
        boxArray[rng].SetActive(true);

        //Setup
        if (!equipped)
        {
            rb.isKinematic = false;
            coll.isTrigger = false;
            fakeNews.enabled = false;
            trueNews.enabled = true;
        }

        if (equipped)
        {
            rb.isKinematic = true;
            coll.isTrigger = true;
            slotFull = true;
            fakeNews.enabled = true;
            trueNews.enabled = false;
        }
    }

    private void Update()
    {
        //Check if player is in range and 'E' is pressed
        Vector3 distanceToPlayer = player.position - transform.position;
        if (!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotFull) PickUp();

        if (!equipped && triggerMail.NewMailTriggerCheck && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
            for (int i = 0; i < homeArray.Length; i++)
            {
                homeArray[i].enabled = false;
                boxArray[i].SetActive(false);
            }
            rng = Random.Range(0, homeArray.Length);
            Debug.Log(homeArray[rng]);
            homeArray[rng].enabled = true;
            boxArray[rng].SetActive(true);
            //e assign uma nova casa random para ficar outlined, mostrar no minimapa e poder consumir um novo chip
        }

        //Throw if equipped and 'Q' is pressed
        if (equipped && Input.GetKeyDown(KeyCode.Q)) Drop();

        if (equipped)
        {
            trueNews.transform.position = fakeNews.transform.position;
        }
    }

    private void PickUp()
    {
        equipped = true;
        slotFull = true;

        //Make weapon a child of the camera and move it to default position when picked up
        transform.SetParent(gunContainer);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;
        
        


        //Make rigidbody kinematic and BoxCollider normal
        rb.isKinematic = true;
        coll.isTrigger = true;

        fakeNews.enabled = true;
        trueNews.enabled = false;

    }

    private void Drop()
    {
        equipped = false;
        slotFull = false;
        fakeNews.enabled = false;
        trueNews.enabled = true;

        //Set parent to null
        transform.SetParent(null);


        //Make rigidbody kinematic and BoxCollider normal
        rb.isKinematic = false;
        coll.isTrigger = false;

        //Gun carries momentum of player
        rb.velocity = player.GetComponent<Rigidbody>().velocity;
        woosh.Play();

        //Add force when throwing weapon
        rb.AddForce(fpsCam.forward * dropForwardForce, ForceMode.Impulse);
        rb.AddForce(fpsCam.up * dropUpwardForce, ForceMode.Impulse);

        //Add random torque rotation when throwing 
        /*float random = Random.Range(0f, 1f);
        rb.AddTorque(new Vector3(random, random, random) * 10);*/


    }
}
