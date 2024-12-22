using System;
using UnityEngine;

public abstract class GameEventListenerBase<T> : MonoBehaviour
{
    [SerializeField] private GameEventBase<T> gameEvent;

    protected abstract void OnEventRaised(T data);
    protected abstract void OnEventRaisedVoid();

    private void OnEnable()
    {
        if (gameEvent != null)
        {
            gameEvent.OnEventRaised += OnEventRaised;
            gameEvent.OnEventRaisedVoid += OnEventRaisedVoid;
        }
    }

    private void OnDisable()
    {
        if (gameEvent != null)
        {
            gameEvent.OnEventRaised -= OnEventRaised;
            gameEvent.OnEventRaisedVoid -= OnEventRaisedVoid;
        }
    }
}
