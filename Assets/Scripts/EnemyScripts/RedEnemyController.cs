using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemyController : EnemyController
{

    [SerializeField] protected GameObject rayOriginTwo;
    [SerializeField] protected GameObject rayOriginThree;

    public override void FindPlayer()
    {
        base.FindPlayer();
        BroadCastRaycast(rayOriginTwo.transform);
        BroadCastRaycast(rayOriginThree.transform);
    }

    public override void DrawRaycast()
    {
        base.DrawRaycast();
        DrawRay(rayOriginTwo.transform);
        DrawRay(rayOriginThree.transform);
    }
}
