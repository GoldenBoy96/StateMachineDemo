using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogIdleState : DogBaseState
{
    int cooldown;
    public override void EnterState(DogStateManager dog)
    {
        dog.animator.SetInteger("Anim", 0);
        cooldown = Random.Range(0, 1000);
    }

    public override void OnTriggerCollision(DogStateManager dog)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(DogStateManager dog)
    {
        if (cooldown > 0)
        {
            cooldown--;
        }
        else
        {
            dog.SwitchState(dog.moveState);
        }
    }


}
