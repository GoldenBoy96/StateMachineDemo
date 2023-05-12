using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class DogMoveState : DogBaseState
{
    int cooldown;
    int direction;
    public override void EnterState(DogStateManager dog)
    {
        dog.animator.SetInteger("Anim", 1);
        cooldown = Random.Range(100, 1000);
        direction = Random.Range(1, 3);
    }

    public override void OnTriggerCollision(DogStateManager dog)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(DogStateManager dog)
    {
        if (cooldown > 0)
        {
            switch (direction)
            {
                case 2:
                    dog.rb.AddForce(new Vector2(1f, 0));
                    dog.transform.localRotation = Quaternion.Euler(0, 180, 0);
                    break;
                case 1:
                    dog.rb.AddForce(new Vector2(-1f, 0));
                    dog.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    break;
            }
            
            cooldown--;
        }
        else
        {
            dog.SwitchState(dog.idleState);
        }
    }


}
