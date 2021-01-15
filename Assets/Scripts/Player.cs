using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    private PlayerController pc;
    private SpriteRenderer playerSpriteR;
    private float lastAngle;

    private void Awake()
    {
        lastAngle = 0;
        pc = new PlayerController();
        playerSpriteR = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        pc.Enable();
    }


    private void OnDisable()
    {
        pc.Disable();
    }

    void Start()
    {

    }

    private void FixedUpdate()
    {
        Vector3 movement = pc.Terrain.Movement.ReadValue<Vector2>();
        transform.position += movement * Time.deltaTime * playerSpeed;

        if (movement.x != 0)
        {
            // transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
            playerSpriteR.flipX = movement.x < 0;
        }
        // transform.rotation = Quaternion.AngleAxis(movement.x < 0? 180 : 0 , Vector3.up);


        if (movement != Vector3.zero)
        {
            float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
            // Mathf.Atan2(movement.x * -1, movement.y) * Mathf.Rad2Deg
            // print(angle + " " + Vector3.Angle(movement, Vector3.right));
            if (lastAngle != angle)
            {
                transform.GetChild(0).RotateAround(transform.position, Vector3.forward, -lastAngle);
                transform.GetChild(0).RotateAround(transform.position, Vector3.forward, angle);
            }

            lastAngle = angle;
        }


    }

    // Update is called once per frame
    void Update()
    {


    }
}
