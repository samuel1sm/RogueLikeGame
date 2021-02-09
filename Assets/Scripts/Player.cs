using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using weapons.GenericTypes;


public class Player : MonoBehaviour
{
    [SerializeField] private float itemCollectionRadious;
    [SerializeField] private List<WeaponSo> weapons;
    [SerializeField] private LayerMask collectLayer;
    [SerializeField] private float playerSpeed;

    private AttackController _attackController;
    private SpriteRenderer _playerSpriteR;
    private WeaponSo _atualWeapon;
    private RaycastHit2D _lastItem;
    private PlayerController _pc;
    private float _lastAngle;
    private Rigidbody2D _rb;

    public event Action<WeaponSo> OnWeaponChanged = delegate { };

    private void Awake()
    {

        _lastAngle = 0;
        _pc = new PlayerController();
        _playerSpriteR = GetComponent<SpriteRenderer>();
        _rb = GetComponent<Rigidbody2D>();
        _attackController = GetComponentInChildren<AttackController>();
    }

    private void OnEnable()
    {
        _pc.Enable();
    }


    private void OnDisable()
    {
        _pc.Disable();
    }

    void Start()
    {
        ChangeWeapon();

        _pc.Terrain.Attack.performed += _ => Attack();
        _pc.Terrain.ChangeWeapon.performed += _ => ChangeWeapon();
        _pc.Terrain.CollectItem.performed += _ => CollectItem();

    }



    private void FixedUpdate()
    {
        Vector3 movement = _pc.Terrain.Movement.ReadValue<Vector2>();
        _rb.MovePosition(transform.position + movement * (Time.deltaTime * playerSpeed));
        if (movement.x != 0)
        {
            _playerSpriteR.flipX = movement.x < 0;
        }


        if (movement != Vector3.zero)
        {
            float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;

            if (_lastAngle != angle)
            {
                var position = transform.position;
                transform.GetChild(0).RotateAround(position, Vector3.forward, -_lastAngle);
                transform.GetChild(0).RotateAround(position, Vector3.forward, angle);


            }

            _lastAngle = angle;
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


    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.tag);
    }


    private void CollectItem()
    {
        if (_lastItem.collider != null)
        {
            if (_lastItem.transform.CompareTag("Weapon"))
            {
                Instantiate(_atualWeapon.collectablePrefab, _lastItem.transform.position, Quaternion.identity);
                _atualWeapon = _lastItem.transform.GetComponent<CollectableWeapon>().GetItemSo();
                weapons[1] = _atualWeapon;
                Destroy(_lastItem.transform.gameObject);
                _lastItem = new RaycastHit2D();
                UpdateAnimation();
            }
        }
    }

    private void ActivateItem(bool activate)
    {
        if (activate)
        {
            _lastItem.transform.GetComponent<SpriteRenderer>().color = Color.gray;
            _lastItem.transform.GetChild(0).gameObject.SetActive(true);
        }
        else{
            _lastItem.transform.GetComponent<SpriteRenderer>().color = Color.white;
            _lastItem.transform.GetChild(0).gameObject.SetActive(false);

        }
    }


    private bool ItemRangeCollect()
    {
        RaycastHit2D item = Physics2D.CircleCast(transform.position, itemCollectionRadious, Vector2.left, 0 ,collectLayer);


        if (item.collider != null)
        {

            if (item.collider != _lastItem.collider && _lastItem.collider != null)
                ActivateItem(false);

            _lastItem = item;
            ActivateItem(true);

            return true;
        }
        else
        {

            if(_lastItem.collider != null)
            {
                ActivateItem(false);
                _lastItem = item;
            }

            return false;
        }
    }

    private void UpdateAnimation()
    {
        OnWeaponChanged(_atualWeapon);
        //attackController.ChangeWeapon(atualWeapon.GetComponent<GenericWeapon>());
    }

    private void ChangeWeapon()
    {
        //atualWeapon = weapons.Dequeue();
        _atualWeapon = weapons[0];
        UpdateAnimation();
        weapons.Add(_atualWeapon);
        weapons.RemoveAt(0);
    }

    public void Attack()
    {
        _attackController.Attack();
    }

    public WeaponSo GetEquipedWeapon()
    {
        return _atualWeapon;
    }


}
