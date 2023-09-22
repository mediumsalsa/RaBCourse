using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraController : MonoBehaviour
{

    public GameObject Player;
    private Vector3 offset;



    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    public float turnSensitivity = 50;

    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;

        if (Input.GetKey(KeyCode.Space))
        {
            transform.RotateAround(Player.transform.position, Vector3.up, turnSensitivity * Time.deltaTime);
            offset = transform.position - Player.transform.position;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.RotateAround(Player.transform.position, Vector3.up, -turnSensitivity * Time.deltaTime);
            offset = transform.position - Player.transform.position;
        }

    }
}
