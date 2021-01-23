using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadNode : MonoBehaviour
{
    public event Action obstructionCleared;

    [SerializeField]
    private RoadNode[] forwardNodes = default;

    private Vehicle[] entryQue = default;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
