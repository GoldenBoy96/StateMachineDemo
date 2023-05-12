using System.Collections;
using System.Collections.Generic;


public abstract class DogBaseState
{
    public abstract void EnterState(DogStateManager dog);

    public abstract void UpdateState(DogStateManager dog);

    public abstract void OnTriggerCollision(DogStateManager dog);



}
