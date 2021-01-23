using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField]
    private RoadNode[] wayPoints = default;

    private RoadNode headingNode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HeadingTo(RoadNode node)
    {
        headingNode = node;
    }
}
