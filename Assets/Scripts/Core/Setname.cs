using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setname : MonoBehaviour
{
    [SerializeField] StringGameEvent stringGameEvent;

    // Start is called before the first frame update
    void Start()
    {
        stringGameEvent.Raise();
    }
}
