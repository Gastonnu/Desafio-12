using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] protected GameObject rayOriginOne;
    [SerializeField] private GameObject player;

    [SerializeField] private EnemyData data;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FindPlayer();

    }

    private void Move()
    {
        Vector3 direction = PlayerDirection();
        transform.Translate(direction * data.speed * Time.deltaTime);
    }

    private Vector3 PlayerDirection()
    {
        Vector3 position = player.transform.position - transform.position;
        Vector3 direction = new Vector3(position.x, 0, position.z);
        return direction;
    }

    public virtual void FindPlayer()
    {
        BroadCastRaycast(rayOriginOne.transform);
    }

    protected void BroadCastRaycast(Transform origin)
    {
        RaycastHit hit;
        if (Physics.Raycast(origin.position, origin.TransformDirection(Vector3.forward), out hit, data.distanceRay))
        {
            if (hit.transform.CompareTag("Player"))
            {
                Move();
            }
        }
    }

    protected void DrawRay(Transform origin)
    {
        Gizmos.color = Color.red;
        Vector3 direction = origin.TransformDirection(Vector3.forward) * data.distanceRay;
        Gizmos.DrawRay(origin.position, direction);
    }

    public virtual void DrawRaycast()
    {
        DrawRay(rayOriginOne.transform);
    }

    private void OnDrawGizmos()
    {
        DrawRaycast();
    }
}
