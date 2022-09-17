using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{

    public enum State
    {
        idle,
        walking,
        swimming,
        climbing
    }
    public State currentState = State.idle;
    Vector3 lastPos;

    void Start()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case State.idle: Idle(); break;
            case State.walking: Walking(); break;
            case State.swimming: Swimming(); break;
            case State.climbing: Climbing(); break;
        }
    }
    void OnTriggerEnter(Collider other)
    {
    }
    void OnTriggerExit(Collider other)
    {
    }
    void Swimming()
    {
        Debug.Log("I am swimming");

    }
    void Climbing()
    {
        Debug.Log("I am climbing");

    }
    void Idle()
    {
        Debug.Log("I am idle");
        if (lastPos != transform.position)
        {
            Debug.Log("Moving");
        }
        lastPos = transform.position;

    }
    void Walking()
    {
        Debug.Log("I am Walking");
        if (lastPos == transform.position)
        {
            Debug.Log("Stoped");
        }
        lastPos = transform.position;
    }
}
