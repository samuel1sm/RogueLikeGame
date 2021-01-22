using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    [SerializeField] private float itemCollectionRadious;
    [SerializeField] private List<GameObject> weapons;
    [SerializeField] private LayerMask collectLayer;
    [SerializeField] private float playerSpeed;

    private AttackController attackController;
    private PlayerController pc;
    private SpriteRenderer playerSpriteR;
    private GameObject atualWeapon;
    private RaycastHit2D lastItem;
    private Rigidbody2D rb;
    private float lastAngle;

    private void Awake()
    {

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
        ChangeWeapon();

        pc.Terrain.Attack.performed += _ => Attack();
        pc.Terrain.ChangeWeapon.performed += _ => ChangeWeapon();
        pc.Terrain.CollectItem.performed += _ => CollectItem();
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

        ItemRangeCollect();

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, itemCollectionRadious);
    }


    private void CollectItem()
    {
        if (lastItem.collider != null)
        {
            if (lastItem.transform.tag == "Weapon")
            {
                GameObject previusWeapon =  Instantiate(atualWeapon);
                previusWeapon.transform.position = transform.position;
                atualWeapon = lastItem.transform.gameObject;
                weapons[1] = atualWeapon;
                Destroy(lastItem.transform.gameObject);
                lastItem = new RaycastHit2D();
                UpdateAnimation();
            }
        }
    }

    private void ActivateItem(bool activate)
    {
        if (activate)
        {
            lastItem.transform.GetComponent<SpriteRenderer>().color = Color.gray;
            lastItem.transform.GetChild(0).gameObject.SetActive(true);
        }
        else{
            lastItem.transform.GetComponent<SpriteRenderer>().color = Color.white;
            lastItem.transform.GetChild(0).gameObject.SetActive(false);

        }
    }


    private bool ItemRangeCollect()
    {
        RaycastHit2D item = Physics2D.CircleCast(transform.position, itemCollectionRadious, Vector2.left, 0 ,collectLayer);


        if (item.collider != null)
        {

            if (item.collider != lastItem.collider && lastItem.collider != null)
                ActivateItem(false);

            lastItem = item;
            ActivateItem(true);

            return true;
        }
        else
        {

            if(lastItem.collider != null)
            {
                ActivateItem(false);
                lastItem = item;
            }

            return false;
        }
    }

    private void UpdateAnimation()
    {
        attackController.ChangeWeapon(atualWeapon.GetComponent<GenericWeapon>());
    }

    private void ChangeWeapon()
    {
        //atualWeapon = weapons.Dequeue();
        atualWeapon = weapons[0];
        UpdateAnimation();
        weapons.Add(atualWeapon);
        weapons.RemoveAt(0);
    }

    public void Attack()
    {
        attackController.Attack(atualWeapon.GetComponent<GenericWeapon>());
    }


}
