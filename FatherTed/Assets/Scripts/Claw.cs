using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Claw : MonoBehaviour
{
    [SerializeField] public SphereCollider[] myColliders;

    List<Transform> AllTargets = new List<Transform>();

    public SphereCollider radcol;

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
    public bool dropping;

    public int index;

    public float Timer = 0.0f;
    public float time = 5; //wait time
    private bool has;
    public bool grab;

    public string naym;


    // Start is called before the first frame update
    void Start()
    {
        clawRoot = GameObject.Find("Claw Anchor").transform;
        player = GameObject.Find("Player").transform;
        dropArea = GameObject.Find("Chute").transform;
        navAgent = clawRoot.GetComponent<NavMeshAgent>(); //where's the navmesh?

        ChangeTarget();

        Chase();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        naym = GameObject.Find("Respawner").GetComponent<chute>().name;

        for (int i = 0; i < AllTargets.Count; i++)
        {

            if (AllTargets[i].name.Contains(naym))
            {
                Debug.Log("equal");
                return;
            }
        }

        retrieve = GameObject.Find("PickupRad").GetComponent<pickupdetect>().close;
        grab = GameObject.Find("Pickuper").GetComponent<pickuper>().grab;
        //retract = GameObject.Find("Pickuper").GetComponent<pickuper>().retrac; //check if player is crouching rn

        Timers();

        if (8 > Vector3.Distance(dropArea.position, transform.position))
        {
            Drop();
        }

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
        navAgent.SetDestination(currentChaseTarget.position); //goto wp
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
        Debug.Log("DROP");

        dropping = true;

        //ChangeTarget();

        //player.parent = null;
        //player.GetComponent<Rigidbody>().isKinematic = false;

        if(currentlyTouching != null)
        {
            currentlyTouching.GetComponent<Rigidbody>().isKinematic = false; //swap currentlytouching to a list and use foreach?
            currentlyTouching.GetComponent<Rigidbody>().useGravity = true;

            currentlyTouching.transform.parent = null;

            radcol.enabled = true;

        }
    }

    public void ChangeTarget()
    {

        index = Random.Range(0, AllTargets.Count);
        currentChaseTarget = AllTargets[index];
        Debug.Log("Changing Target to " + AllTargets[index]);
    }

    void Timers()
    {
        Timer += Time.deltaTime;

        if (Timer > time)
        {
            Timer = Timer - time;
            has = true;
            move = true;
            retract = false;
            Debug.Log("Timer");

            if (dropping)
            {
                dropping = false;

            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Targetable" && grab && !dropping)
        {
            Debug.Log("Colliding with " + col.name);
            //col.transform.parent = this.transform;
            //col.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            //col.gameObject.GetComponent<Rigidbody>().useGravity = false;

            //GameObject.Find("Pickuper").GetComponent<pickuper>().grab = false;


            currentlyTouching = col.gameObject;
            currentlyTouching.transform.parent = this.transform;
            currentlyTouching.gameObject.GetComponent<Rigidbody>().useGravity = false;


            if (currentlyTouching.name == "AITeddy")
            {
                currentlyTouching.gameObject.GetComponent<WanderAi>().enabled = false;
            }

            Debug.Log("retract on");
            retract = true;

            radcol.enabled = false;

        }
    }

    private void OnTriggerStay(Collider col)
    {
        //currentlyTouching = col.gameObject;
    }

    private void OnTriggerExit(Collider col)
    {

        if (col.tag == "Targetable")
        {

            currentlyTouching = null;

        }
    }
}
