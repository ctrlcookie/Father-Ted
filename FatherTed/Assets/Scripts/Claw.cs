using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Claw : MonoBehaviour
{

    public Transform clawRoot; //what's to be moved in order to move claw
    public Transform dropArea;

    public Transform player;
    public Transform currentChaseTarget;
    public NavMeshAgent navAgent;
    public GameObject currentlyTouching;

    public float winchSpeed;

    public bool move = false;
    public bool retrieve = false;
    public bool retract = false;
    public bool travel = false;
    public bool drop = false;


    public float Timer = 0.0f;
    public float time = 5; //wait time
    private bool has;
    public bool grab;


    // Start is called before the first frame update
    void Start()
    {
        clawRoot = GameObject.Find("Claw Anchor").transform;
        player = GameObject.Find("Player").transform;
        dropArea = GameObject.Find("Chute").transform;
        navAgent = clawRoot.GetComponent<NavMeshAgent>(); //where's the navmesh?

        Chase();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        retrieve = GameObject.Find("PickupRad").GetComponent<pickupdetect>().close; //check if player is crouching rn
        grab = GameObject.Find("Pickuper").GetComponent<pickuper>().grab; //check if player is crouching rn
        //retract = GameObject.Find("Pickuper").GetComponent<pickuper>().retrac; //check if player is crouching rn

        Timers();

        if (move)
        {
            Chase();
            move = false;
        }
        if (retrieve)
        {
            Retrieve();
        }
        if (retract)
        {
            Retract();
        }
        else if (travel || currentlyTouching != null)
        {

            Travel();
        }
        else if (drop)
        {
            Drop();
        }
    }

    public void Chase()
    {
        navAgent.SetDestination(player.position); //goto wp
        Debug.Log("CHASE");
    }

    public void Retrieve()
    {
        Debug.Log("RETRIEVE");

        if (navAgent.baseOffset >= -4)
        {
            navAgent.baseOffset -= winchSpeed;
        }
    }

    public void Retract()
    {
        Debug.Log("RETRACT");

        if (navAgent.baseOffset <= 0)
        {
            navAgent.baseOffset += winchSpeed;
        }
    }

    public void Travel()
    {
        Debug.Log("TRAVEL");

        navAgent.SetDestination(dropArea.position); //goto wp
    }

    public void Drop()
    { 
        //currentlyTouching.parent = null;
        currentlyTouching.GetComponent<Rigidbody>().isKinematic = false;
        currentlyTouching.GetComponent<Rigidbody>().useGravity = true;
        currentlyTouching.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
    }

    void Timers()
    {
        Timer += Time.deltaTime;

        if (Timer > time)
        {
            Timer = Timer - time;
            has = true;
            move = true;
            Debug.Log("Timer");
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("Collidin");

        if (col.tag == "Targetable" && grab)
        {
            Debug.Log("Colliding with "+  col.name);
            col.transform.parent = this.transform;
            col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            col.gameObject.GetComponent<Rigidbody>().useGravity = false;

            currentlyTouching = col.gameObject;


            Debug.Log("retract on");
            retract = true;
        }
    }
}
