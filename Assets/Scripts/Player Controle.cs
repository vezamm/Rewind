//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Player Controle.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControle: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControle()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controle"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""643272f0-d437-4830-a0e7-20d86b54a915"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5dd2a0cc-b2e0-4c93-9a2c-dc319d02077d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a5d50729-3ec5-4852-b00a-40dc4d571d4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""mouselook"",
                    ""type"": ""PassThrough"",
                    ""id"": ""126a0666-838a-4aa7-a082-8747adcca8f7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprinting"",
                    ""type"": ""Button"",
                    ""id"": ""8c602cb2-094f-45b6-b1ea-ee52a7bcd9de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Gun shooting"",
                    ""type"": ""Button"",
                    ""id"": ""701902e6-81e6-4894-b47b-b603bae0d70a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap(duration=1E-06)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Gun reloading"",
                    ""type"": ""Button"",
                    ""id"": ""63c77983-1caa-4c2d-9487-6f212704bb3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26004c7b-3c9a-492a-81d6-ec531ac2b24c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""26bf89b0-c621-4ebf-8bed-e6c06e52c99a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cc961e5f-64d1-4682-8447-ec3494c6809f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fdb535bd-dff9-4d36-8145-62f40bf661e7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bfc72c07-80df-45af-94ac-ec2401601062"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a82e7d8b-15b9-41b0-834f-ca1171f8e32b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""44cfc6e8-ac0d-4eb1-819c-3d7624cba395"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouselook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cc6d15f-e2ba-47fa-a366-1dff3db77339"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprinting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e415ab1-ff9a-41e4-8c8d-282ee3550318"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gun shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8eaddc56-a558-49e9-b3f2-fecf3fb0b279"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gun reloading"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_Move = m_Land.FindAction("Move", throwIfNotFound: true);
        m_Land_Jump = m_Land.FindAction("Jump", throwIfNotFound: true);
        m_Land_mouselook = m_Land.FindAction("mouselook", throwIfNotFound: true);
        m_Land_Sprinting = m_Land.FindAction("Sprinting", throwIfNotFound: true);
        m_Land_Gunshooting = m_Land.FindAction("Gun shooting", throwIfNotFound: true);
        m_Land_Gunreloading = m_Land.FindAction("Gun reloading", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Land
    private readonly InputActionMap m_Land;
    private List<ILandActions> m_LandActionsCallbackInterfaces = new List<ILandActions>();
    private readonly InputAction m_Land_Move;
    private readonly InputAction m_Land_Jump;
    private readonly InputAction m_Land_mouselook;
    private readonly InputAction m_Land_Sprinting;
    private readonly InputAction m_Land_Gunshooting;
    private readonly InputAction m_Land_Gunreloading;
    public struct LandActions
    {
        private @PlayerControle m_Wrapper;
        public LandActions(@PlayerControle wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Land_Move;
        public InputAction @Jump => m_Wrapper.m_Land_Jump;
        public InputAction @mouselook => m_Wrapper.m_Land_mouselook;
        public InputAction @Sprinting => m_Wrapper.m_Land_Sprinting;
        public InputAction @Gunshooting => m_Wrapper.m_Land_Gunshooting;
        public InputAction @Gunreloading => m_Wrapper.m_Land_Gunreloading;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void AddCallbacks(ILandActions instance)
        {
            if (instance == null || m_Wrapper.m_LandActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_LandActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @mouselook.started += instance.OnMouselook;
            @mouselook.performed += instance.OnMouselook;
            @mouselook.canceled += instance.OnMouselook;
            @Sprinting.started += instance.OnSprinting;
            @Sprinting.performed += instance.OnSprinting;
            @Sprinting.canceled += instance.OnSprinting;
            @Gunshooting.started += instance.OnGunshooting;
            @Gunshooting.performed += instance.OnGunshooting;
            @Gunshooting.canceled += instance.OnGunshooting;
            @Gunreloading.started += instance.OnGunreloading;
            @Gunreloading.performed += instance.OnGunreloading;
            @Gunreloading.canceled += instance.OnGunreloading;
        }

        private void UnregisterCallbacks(ILandActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @mouselook.started -= instance.OnMouselook;
            @mouselook.performed -= instance.OnMouselook;
            @mouselook.canceled -= instance.OnMouselook;
            @Sprinting.started -= instance.OnSprinting;
            @Sprinting.performed -= instance.OnSprinting;
            @Sprinting.canceled -= instance.OnSprinting;
            @Gunshooting.started -= instance.OnGunshooting;
            @Gunshooting.performed -= instance.OnGunshooting;
            @Gunshooting.canceled -= instance.OnGunshooting;
            @Gunreloading.started -= instance.OnGunreloading;
            @Gunreloading.performed -= instance.OnGunreloading;
            @Gunreloading.canceled -= instance.OnGunreloading;
        }

        public void RemoveCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ILandActions instance)
        {
            foreach (var item in m_Wrapper.m_LandActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_LandActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public LandActions @Land => new LandActions(this);
    public interface ILandActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouselook(InputAction.CallbackContext context);
        void OnSprinting(InputAction.CallbackContext context);
        void OnGunshooting(InputAction.CallbackContext context);
        void OnGunreloading(InputAction.CallbackContext context);
    }
}
