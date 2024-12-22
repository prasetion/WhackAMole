using System;
using UnityEngine;

public abstract class GameEventBase<T> : ScriptableObject
{
    public event Action<T> OnEventRaised;
    public event Action OnEventRaisedVoid;
    public T Data;

    public void Raise()
    {
        Debug.Log($"Event Raised with Data: {Data}");
        OnEventRaised?.Invoke(Data);
    }

    public void RaiseVoid()
    {
        Debug.Log("Event Raised");
        OnEventRaisedVoid?.Invoke();
    }
}
