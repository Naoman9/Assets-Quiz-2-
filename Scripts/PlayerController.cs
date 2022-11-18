using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 turnPlayer;

    private float speed = 50.0f;

    public GameObject bullet;
    public bool canFire;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        MouseController();

    }

    // Controlling player forward and backward
   void PlayerMovement()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward  * speed * Time.deltaTime);
        }

        if (Input.GetKey("down"))
        {
            transform.Translate(Vector3.back  * speed * Time.deltaTime);
        }

        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey("left"))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

    }

    // Controlling shooting and directions
    void MouseController()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, player.transform.position, player.transform.rotation);
        }

        turnPlayer.x += Input.GetAxis("Mouse X") * Time.deltaTime * 500;

        transform.localRotation = Quaternion.Euler(0, turnPlayer.x, 0);
    }
}
