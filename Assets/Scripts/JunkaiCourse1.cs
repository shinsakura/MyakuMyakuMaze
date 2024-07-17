using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JunkaiCourse1 : MonoBehaviour
{
    public Transform[] goals;
    public int pointNum = 5;
    private int destNum = 0;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goals[destNum].position;
    }

    void nextGoal()
    {

        destNum += 1;
        if (destNum == pointNum)
        {
            destNum = 0;
        }

        agent.destination = goals[destNum].position;

        Debug.Log(destNum);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(agent.remainingDistance);
        if (agent.remainingDistance < 0.5f)
        {
            nextGoal();
        }

    }
}
