using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowEnemyController : EnemyController
{

    [SerializeField] protected GameObject rayOriginTwo;
    [SerializeField] protected GameObject rayOriginThree;
    [SerializeField] protected GameObject rayOriginFour;

    public override void FindPlayer()
    {
        base.FindPlayer();
        BroadCastRaycast(rayOriginTwo.transform);
        BroadCastRaycast(rayOriginThree.transform);
        BroadCastRaycast(rayOriginFour.transform);
    }

    public override void DrawRaycast()
    {
        base.DrawRaycast();
        DrawRay(rayOriginTwo.transform);
        DrawRay(rayOriginThree.transform);
        DrawRay(rayOriginFour.transform);
    }
}