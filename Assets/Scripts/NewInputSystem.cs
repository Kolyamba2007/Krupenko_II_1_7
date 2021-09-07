// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/InputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @NewInputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewInputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystem"",
    ""maps"": [
        {
            ""name"": ""WASD"",
            ""id"": ""43987355-9621-4617-b771-164cf1c6bdf3"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c40e9836-915b-455e-8e81-b5d1b9e14f1a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightMove"",
                    ""type"": ""Button"",
                    ""id"": ""b6d6002d-03d0-4f02-a4ea-0b04df44d029"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftMove"",
                    ""type"": ""Button"",
                    ""id"": ""66855e3e-7959-4c5d-b16a-75dc10edce0a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Slide"",
                    ""type"": ""Button"",
                    ""id"": ""facc9d2b-3b45-439d-add7-f9827fbbdd39"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""99850373-089d-4dc0-b1ad-d3084eea4687"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b15554b-ff46-4c94-a135-9887882def76"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6438c60c-862e-400b-aa40-24c8909d09cf"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd28a12e-51e5-4344-8a87-8fc7281bf60b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Arrows"",
            ""id"": ""18018c71-ed79-48ad-bc98-8f6a8fcece15"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""affdb410-1f67-41c7-90a9-40fe848340f0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightMove"",
                    ""type"": ""Button"",
                    ""id"": ""54b9e112-d676-402b-9718-bc93dae5dc4e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftMove"",
                    ""type"": ""Button"",
                    ""id"": ""861eb6ff-b5b0-438d-9955-cdfe188a18ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Slide"",
                    ""type"": ""Button"",
                    ""id"": ""23134632-093c-4e23-8efa-b7f29022a8ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3bf94cde-b2d6-40a1-bf32-cf40ca26c8d1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2d12dd7-26ed-4720-b572-050550d11b70"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e19c56c-1203-4258-8b57-94fc3f9a0b46"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""737e97e5-deeb-4391-aba4-917cf0fccb97"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // WASD
        m_WASD = asset.FindActionMap("WASD", throwIfNotFound: true);
        m_WASD_Jump = m_WASD.FindAction("Jump", throwIfNotFound: true);
        m_WASD_RightMove = m_WASD.FindAction("RightMove", throwIfNotFound: true);
        m_WASD_LeftMove = m_WASD.FindAction("LeftMove", throwIfNotFound: true);
        m_WASD_Slide = m_WASD.FindAction("Slide", throwIfNotFound: true);
        // Arrows
        m_Arrows = asset.FindActionMap("Arrows", throwIfNotFound: true);
        m_Arrows_Jump = m_Arrows.FindAction("Jump", throwIfNotFound: true);
        m_Arrows_RightMove = m_Arrows.FindAction("RightMove", throwIfNotFound: true);
        m_Arrows_LeftMove = m_Arrows.FindAction("LeftMove", throwIfNotFound: true);
        m_Arrows_Slide = m_Arrows.FindAction("Slide", throwIfNotFound: true);
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

    // WASD
    private readonly InputActionMap m_WASD;
    private IWASDActions m_WASDActionsCallbackInterface;
    private readonly InputAction m_WASD_Jump;
    private readonly InputAction m_WASD_RightMove;
    private readonly InputAction m_WASD_LeftMove;
    private readonly InputAction m_WASD_Slide;
    public struct WASDActions
    {
        private @NewInputSystem m_Wrapper;
        public WASDActions(@NewInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_WASD_Jump;
        public InputAction @RightMove => m_Wrapper.m_WASD_RightMove;
        public InputAction @LeftMove => m_Wrapper.m_WASD_LeftMove;
        public InputAction @Slide => m_Wrapper.m_WASD_Slide;
        public InputActionMap Get() { return m_Wrapper.m_WASD; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WASDActions set) { return set.Get(); }
        public void SetCallbacks(IWASDActions instance)
        {
            if (m_Wrapper.m_WASDActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_WASDActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_WASDActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_WASDActionsCallbackInterface.OnJump;
                @RightMove.started -= m_Wrapper.m_WASDActionsCallbackInterface.OnRightMove;
                @RightMove.performed -= m_Wrapper.m_WASDActionsCallbackInterface.OnRightMove;
                @RightMove.canceled -= m_Wrapper.m_WASDActionsCallbackInterface.OnRightMove;
                @LeftMove.started -= m_Wrapper.m_WASDActionsCallbackInterface.OnLeftMove;
                @LeftMove.performed -= m_Wrapper.m_WASDActionsCallbackInterface.OnLeftMove;
                @LeftMove.canceled -= m_Wrapper.m_WASDActionsCallbackInterface.OnLeftMove;
                @Slide.started -= m_Wrapper.m_WASDActionsCallbackInterface.OnSlide;
                @Slide.performed -= m_Wrapper.m_WASDActionsCallbackInterface.OnSlide;
                @Slide.canceled -= m_Wrapper.m_WASDActionsCallbackInterface.OnSlide;
            }
            m_Wrapper.m_WASDActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @RightMove.started += instance.OnRightMove;
                @RightMove.performed += instance.OnRightMove;
                @RightMove.canceled += instance.OnRightMove;
                @LeftMove.started += instance.OnLeftMove;
                @LeftMove.performed += instance.OnLeftMove;
                @LeftMove.canceled += instance.OnLeftMove;
                @Slide.started += instance.OnSlide;
                @Slide.performed += instance.OnSlide;
                @Slide.canceled += instance.OnSlide;
            }
        }
    }
    public WASDActions @WASD => new WASDActions(this);

    // Arrows
    private readonly InputActionMap m_Arrows;
    private IArrowsActions m_ArrowsActionsCallbackInterface;
    private readonly InputAction m_Arrows_Jump;
    private readonly InputAction m_Arrows_RightMove;
    private readonly InputAction m_Arrows_LeftMove;
    private readonly InputAction m_Arrows_Slide;
    public struct ArrowsActions
    {
        private @NewInputSystem m_Wrapper;
        public ArrowsActions(@NewInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Arrows_Jump;
        public InputAction @RightMove => m_Wrapper.m_Arrows_RightMove;
        public InputAction @LeftMove => m_Wrapper.m_Arrows_LeftMove;
        public InputAction @Slide => m_Wrapper.m_Arrows_Slide;
        public InputActionMap Get() { return m_Wrapper.m_Arrows; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ArrowsActions set) { return set.Get(); }
        public void SetCallbacks(IArrowsActions instance)
        {
            if (m_Wrapper.m_ArrowsActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnJump;
                @RightMove.started -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnRightMove;
                @RightMove.performed -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnRightMove;
                @RightMove.canceled -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnRightMove;
                @LeftMove.started -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnLeftMove;
                @LeftMove.performed -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnLeftMove;
                @LeftMove.canceled -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnLeftMove;
                @Slide.started -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnSlide;
                @Slide.performed -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnSlide;
                @Slide.canceled -= m_Wrapper.m_ArrowsActionsCallbackInterface.OnSlide;
            }
            m_Wrapper.m_ArrowsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @RightMove.started += instance.OnRightMove;
                @RightMove.performed += instance.OnRightMove;
                @RightMove.canceled += instance.OnRightMove;
                @LeftMove.started += instance.OnLeftMove;
                @LeftMove.performed += instance.OnLeftMove;
                @LeftMove.canceled += instance.OnLeftMove;
                @Slide.started += instance.OnSlide;
                @Slide.performed += instance.OnSlide;
                @Slide.canceled += instance.OnSlide;
            }
        }
    }
    public ArrowsActions @Arrows => new ArrowsActions(this);
    public interface IWASDActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnRightMove(InputAction.CallbackContext context);
        void OnLeftMove(InputAction.CallbackContext context);
        void OnSlide(InputAction.CallbackContext context);
    }
    public interface IArrowsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnRightMove(InputAction.CallbackContext context);
        void OnLeftMove(InputAction.CallbackContext context);
        void OnSlide(InputAction.CallbackContext context);
    }
}
