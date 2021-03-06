// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""Terrain"",
            ""id"": ""30543af3-0a08-4f47-a541-ca7b01109f46"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""cdc14bb8-1df7-4aed-b7f6-6ced1a0a9ab8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""69fd0775-c579-433b-ad31-2e3850ed1adf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""d6074c01-cded-4634-ab68-cecfa059499c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CollectItem"",
                    ""type"": ""Button"",
                    ""id"": ""7be2eca5-55d6-40aa-a955-0693cf0f1cfe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Movement"",
                    ""id"": ""09c42363-1af6-4d21-a3ee-6f1dffc7c5d8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""93c70605-2429-48a5-a69f-aea7e0f3bf2b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""300c4939-5a61-425a-9d1f-39c93f8619b5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""195731be-9557-4e25-9c0a-03abb38616dd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f4e9e1f1-4922-4fe9-8f12-f43e91a839a6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1c40c96a-536f-4aba-b2f0-8e6a32b3b268"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30068372-c734-4948-bac5-2f471ce1c8e6"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2c96743-c8b6-4713-9fbe-e45fe58b0c9a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CollectItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Terrain
        m_Terrain = asset.FindActionMap("Terrain", throwIfNotFound: true);
        m_Terrain_Movement = m_Terrain.FindAction("Movement", throwIfNotFound: true);
        m_Terrain_Attack = m_Terrain.FindAction("Attack", throwIfNotFound: true);
        m_Terrain_ChangeWeapon = m_Terrain.FindAction("ChangeWeapon", throwIfNotFound: true);
        m_Terrain_CollectItem = m_Terrain.FindAction("CollectItem", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Terrain
    private readonly InputActionMap m_Terrain;
    private ITerrainActions m_TerrainActionsCallbackInterface;
    private readonly InputAction m_Terrain_Movement;
    private readonly InputAction m_Terrain_Attack;
    private readonly InputAction m_Terrain_ChangeWeapon;
    private readonly InputAction m_Terrain_CollectItem;
    public struct TerrainActions
    {
        private @PlayerController m_Wrapper;
        public TerrainActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Terrain_Movement;
        public InputAction @Attack => m_Wrapper.m_Terrain_Attack;
        public InputAction @ChangeWeapon => m_Wrapper.m_Terrain_ChangeWeapon;
        public InputAction @CollectItem => m_Wrapper.m_Terrain_CollectItem;
        public InputActionMap Get() { return m_Wrapper.m_Terrain; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TerrainActions set) { return set.Get(); }
        public void SetCallbacks(ITerrainActions instance)
        {
            if (m_Wrapper.m_TerrainActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_TerrainActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_TerrainActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_TerrainActionsCallbackInterface.OnMovement;
                @Attack.started -= m_Wrapper.m_TerrainActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_TerrainActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_TerrainActionsCallbackInterface.OnAttack;
                @ChangeWeapon.started -= m_Wrapper.m_TerrainActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.performed -= m_Wrapper.m_TerrainActionsCallbackInterface.OnChangeWeapon;
                @ChangeWeapon.canceled -= m_Wrapper.m_TerrainActionsCallbackInterface.OnChangeWeapon;
                @CollectItem.started -= m_Wrapper.m_TerrainActionsCallbackInterface.OnCollectItem;
                @CollectItem.performed -= m_Wrapper.m_TerrainActionsCallbackInterface.OnCollectItem;
                @CollectItem.canceled -= m_Wrapper.m_TerrainActionsCallbackInterface.OnCollectItem;
            }
            m_Wrapper.m_TerrainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @ChangeWeapon.started += instance.OnChangeWeapon;
                @ChangeWeapon.performed += instance.OnChangeWeapon;
                @ChangeWeapon.canceled += instance.OnChangeWeapon;
                @CollectItem.started += instance.OnCollectItem;
                @CollectItem.performed += instance.OnCollectItem;
                @CollectItem.canceled += instance.OnCollectItem;
            }
        }
    }
    public TerrainActions @Terrain => new TerrainActions(this);
    public interface ITerrainActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnChangeWeapon(InputAction.CallbackContext context);
        void OnCollectItem(InputAction.CallbackContext context);
    }
}
