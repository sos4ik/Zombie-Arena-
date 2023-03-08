using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class SetTranformTarget : MonoBehaviour
{
    Transform target;

    AIDestinationSetter ai;
    void Start()
    {
        ai = GetComponent<AIDestinationSetter>();
        target = Player.singleton.transform;
        ai.target = target;
    }
}
