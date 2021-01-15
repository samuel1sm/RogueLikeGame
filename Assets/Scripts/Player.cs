using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    private PlayerController pc;
    private SpriteRenderer playerSpriteR;

    private void Awake()
    {
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
            transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        // playerSpriteR.flipX = movement.x < 0;


        // if (movement != Vector3.zero)
        // {
        //     float angle = Mathf.Atan2(movement.x * -1, movement.y) * Mathf.Rad2Deg;
        //     transform.GetChild(0).rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        // }

    }

    // Update is called once per frame
    void Update()
    {


    }
}
