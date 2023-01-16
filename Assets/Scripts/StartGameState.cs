using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameState : GameState
{
    public override void CallOnEnter()
    {
        base.CallOnEnter();
    }

    public override void CallOnExit()
    {
        base.CallOnExit();
    }

    protected override void Update()
    {
        Debug.Log(Time.time);
        if(Time.time > 5)
        {
            CallOnExit();
        }
        
    }

}
