using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogStateManager : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;

    public DogBaseState currentState;
    public DogIdleState idleState = new();
    public DogMoveState moveState = new();
    public DogAttackState attackState = new();

    // Start is called before the first frame update
    void Start()
    {
        currentState = idleState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(DogBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
