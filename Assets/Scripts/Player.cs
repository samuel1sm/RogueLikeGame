using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    private AttackController attackController;
    private PlayerController pc;
    private SpriteRenderer playerSpriteR;
    private float lastAngle;
    private Rigidbody2D rb;

    private WeaponType[] playerWeapons = new WeaponType[2];
    private bool firstWeaponSelected;
    private void Awake()
    {
        playerWeapons[0] = WeaponType.SWORD;
        playerWeapons[1] = WeaponType.BOW;
        firstWeaponSelected = false;

        lastAngle = 0;
        pc = new PlayerController();
        playerSpriteR = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        attackController = GetComponentInChildren<AttackController>();
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
        pc.Terrain.Attack.performed += _ => Attack();
        pc.Terrain.ChangeWeapon.performed += _ => ChangeWeapon();

    }



    private void FixedUpdate()
    {
        Vector3 movement = pc.Terrain.Movement.ReadValue<Vector2>();
        rb.MovePosition(transform.position + movement * Time.deltaTime * playerSpeed);
        if (movement.x != 0)
        {
            playerSpriteR.flipX = movement.x < 0;
        }


        if (movement != Vector3.zero)
        {
            float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;

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
    private void ChangeWeapon()
    {

        attackController.ChangeWeapon(firstWeaponSelected? 0 : 1);
        firstWeaponSelected = !firstWeaponSelected;
    }

    public void Attack()
    {
        attackController.Attack(firstWeaponSelected ? 0 : 1);
    }


}
