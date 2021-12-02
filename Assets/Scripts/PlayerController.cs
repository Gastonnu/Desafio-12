using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float cameraAxisX = 180f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        RotatePlayer();
    }

    private void Move()
    {
        float axisX = Input.GetAxisRaw("Horizontal");
        float axisY = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(axisX, 0, axisY);
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void RotatePlayer()
    {
        cameraAxisX += Input.GetAxis("Mouse X");
        Quaternion angle = Quaternion.Euler(0, cameraAxisX, 0);
        transform.localRotation = angle;
    }

}
