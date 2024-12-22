using UnityEngine;

public class StringGameEventListener : GameEventListenerBase<string>
{
    protected override void OnEventRaised(string data)
    {
        // throw new System.NotImplementedException();
        Debug.Log($"recieved with Data: {data}");
    }

    protected override void OnEventRaisedVoid()
    {
    }
}
