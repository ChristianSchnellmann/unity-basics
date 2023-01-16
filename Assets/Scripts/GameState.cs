using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameState : MonoBehaviour
{
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent onUpdate;
    

    virtual public void CallOnEnter()
    {
        this.enabled = true; 
        onEnter.Invoke();
    }

    virtual public void CallOnExit()
    {
        this.enabled = false;
        onExit.Invoke();
    }

    virtual protected void Update()
    {

    }



}
