// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input Management/Characer Controlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CharacerControlls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CharacerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Characer Controlls"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""f024c828-a6a3-4afa-8c27-aeefedca1e38"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""PassThrough"",
                    ""id"": ""18b8d4a8-6a76-46c7-b726-f4ec8dc5c0b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1179d6b4-09c1-42f1-beba-424d54fc4f8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Strafe"",
                    ""type"": ""Button"",
                    ""id"": ""a3b57b2f-f017-4d50-ad1d-6373d7530fc7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SprintStart"",
                    ""type"": ""Button"",
                    ""id"": ""d0e5c37b-ce1c-4567-b50d-04a1bd077f52"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SprintEnd"",
                    ""type"": ""Button"",
                    ""id"": ""f8763e5a-6cb4-49b1-8fa8-ce9f87782187"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""af1761d2-361e-4057-b0db-db87e8288205"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""21727d32-96ef-4d4d-b762-4147061cd66e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cd30d1a7-20b6-415b-b4fb-18a9fa621136"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d70efd0f-3f81-4782-afdd-84a9093f92e2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""eec6c018-5a00-4525-90ae-11b5468f43cb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ab36735b-ec02-4427-bee7-80581d104b9e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3c876132-ed9e-4694-8f14-55950340b7d8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fbb4582b-1ea9-4c19-9c08-78b418908622"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SprintStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcbc2b10-886f-41f1-8c64-f02e1d648ecb"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SprintEnd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_Walk = m_Default.FindAction("Walk", throwIfNotFound: true);
        m_Default_Jump = m_Default.FindAction("Jump", throwIfNotFound: true);
        m_Default_Strafe = m_Default.FindAction("Strafe", throwIfNotFound: true);
        m_Default_SprintStart = m_Default.FindAction("SprintStart", throwIfNotFound: true);
        m_Default_SprintEnd = m_Default.FindAction("SprintEnd", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_Walk;
    private readonly InputAction m_Default_Jump;
    private readonly InputAction m_Default_Strafe;
    private readonly InputAction m_Default_SprintStart;
    private readonly InputAction m_Default_SprintEnd;
    public struct DefaultActions
    {
        private @CharacerControlls m_Wrapper;
        public DefaultActions(@CharacerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Default_Walk;
        public InputAction @Jump => m_Wrapper.m_Default_Jump;
        public InputAction @Strafe => m_Wrapper.m_Default_Strafe;
        public InputAction @SprintStart => m_Wrapper.m_Default_SprintStart;
        public InputAction @SprintEnd => m_Wrapper.m_Default_SprintEnd;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnWalk;
                @Jump.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJump;
                @Strafe.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnStrafe;
                @Strafe.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnStrafe;
                @Strafe.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnStrafe;
                @SprintStart.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSprintStart;
                @SprintStart.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSprintStart;
                @SprintStart.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSprintStart;
                @SprintEnd.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSprintEnd;
                @SprintEnd.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSprintEnd;
                @SprintEnd.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnSprintEnd;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Strafe.started += instance.OnStrafe;
                @Strafe.performed += instance.OnStrafe;
                @Strafe.canceled += instance.OnStrafe;
                @SprintStart.started += instance.OnSprintStart;
                @SprintStart.performed += instance.OnSprintStart;
                @SprintStart.canceled += instance.OnSprintStart;
                @SprintEnd.started += instance.OnSprintEnd;
                @SprintEnd.performed += instance.OnSprintEnd;
                @SprintEnd.canceled += instance.OnSprintEnd;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    public interface IDefaultActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnStrafe(InputAction.CallbackContext context);
        void OnSprintStart(InputAction.CallbackContext context);
        void OnSprintEnd(InputAction.CallbackContext context);
    }
}
