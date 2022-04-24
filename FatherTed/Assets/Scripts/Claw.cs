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

    public bool move = false;
    public bool retrieve = false;
    public bool retract = false;
    public bool travel = false;
    public bool drop = false;



    // Start is called before the first frame update
    void Start()
    {
        clawRoot = GameObject.Find("Claw Anchor").transform;
        player = GameObject.Find("Player").transform;
        dropArea = GameObject.Find("Chute").transform;
        navAgent = clawRoot.GetComponent<NavMeshAgent>(); //where's the navmesh?
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (move)
        {
            Chase();
        }
        else if (retrieve)
        {
            Retrieve();
        }
        if (retract)
        {
            Retract();
        }
        else if (travel)
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

    }

    public void Retrieve()
    {
        if (navAgent.baseOffset >= -4)
        {
            navAgent.baseOffset -= 0.5f;

        }
    }

    public void Retract()
    {
        if (navAgent.baseOffset <= 0)
        {
            navAgent.baseOffset += 0.5f;
        }
    }

    public void Travel()
    {
        navAgent.SetDestination(dropArea.position); //goto wp
    }

    public void Drop()
    {
        player.parent = null;
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("Collidin");

        if (col.tag == "Targetable")
        {
            Debug.Log("Colliding with targetable");
            col.transform.parent = this.transform;
        }
    }

}
