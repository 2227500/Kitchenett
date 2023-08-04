using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Yarn.Unity;

public class walkPositions : MonoBehaviour
{
    public Transform firstPos;
    public Transform sofa;
    public Transform firePlace;
    public NavMeshAgent assistant;

    // Start is called before the first frame update
    void Start()
    {
       // MoveToSofa();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToSofa()
    {
        assistant.destination = sofa.position;
    }

    public void MoveToFirePlace()
    {
        assistant.destination = firePlace.position;
    }

    [YarnCommand("moveToSofa")]
    public void CharacterMover()
    {
        MoveToSofa();
        MoveToFirePlace();
    }

}
