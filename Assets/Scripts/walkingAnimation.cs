using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class walkingAnimation : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Animator animator;
    public float speedDampTime = 0.1f;  // The approximate amount of time it takes for the speed parameter to reach its value upon being set.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Cache the speed that nav mesh agent wants to move at.
        float speed = navMeshAgent.desiredVelocity.magnitude;

        // Set the animator's Speed parameter based on the (possibly modified) speed that the nav mesh agent wants to move at.
        animator.SetFloat("Speed", speed, speedDampTime, Time.deltaTime);

    }
}
