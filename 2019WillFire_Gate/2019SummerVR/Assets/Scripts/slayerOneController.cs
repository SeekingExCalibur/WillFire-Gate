using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class slayerOneController : MonoBehaviour {
    public Transform target;
    private NavMeshAgent myNavAgent;
    private Animator myAnim;

	// Use this for initialization
	void Start () {
        myNavAgent = GetComponent<NavMeshAgent>();
        myAnim = GetComponent<Animator>();
        GoToPoint(target.position);
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(myNavAgent.speed);
        myAnim.SetFloat("Speed", myNavAgent.velocity.magnitude);
	}

    public void GoToPoint(Vector3 target) {
        myNavAgent.SetDestination(target);
    }

}
