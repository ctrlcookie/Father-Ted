// GENERATED AUTOMATICALLY FROM 'Assets/PluginAssets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GameplayControls"",
            ""id"": ""09a1f61b-ab15-484f-94c2-f301be4d5665"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""d4dfe425-78ef-4ce1-b185-fac604748049"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""0ca12ac3-eb7d-4b33-836c-5efec5a779be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""9d8fe85b-1708-4d5b-837e-d183a81a4aed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7d219c9e-3207-4335-8ded-7829d739794c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94ebb19e-4aec-4af9-ba9b-20358ffbe553"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8de12e7-a104-4801-b2f7-4a676e069a57"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""17132539-353a-49d4-b64f-c2e025381713"",
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
                    ""id"": ""58825036-9468-4415-aad5-e3adbe436e70"",
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
                    ""id"": ""e375570d-8cb0-427a-bdc7-29df663579ac"",
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
                    ""id"": ""baebb202-e993-4713-aa7a-9322c6cb3d8b"",
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
                    ""id"": ""db16207b-0e09-4eb2-838d-75e137fa07c7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameplayControls
        m_GameplayControls = asset.FindActionMap("GameplayControls", throwIfNotFound: true);
        m_GameplayControls_Jump = m_GameplayControls.FindAction("Jump", throwIfNotFound: true);
        m_GameplayControls_Crouch = m_GameplayControls.FindAction("Crouch", throwIfNotFound: true);
        m_GameplayControls_Move = m_GameplayControls.FindAction("Move", throwIfNotFound: true);
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

    // GameplayControls
    private readonly InputActionMap m_GameplayControls;
    private IGameplayControlsActions m_GameplayControlsActionsCallbackInterface;
    private readonly InputAction m_GameplayControls_Jump;
    private readonly InputAction m_GameplayControls_Crouch;
    private readonly InputAction m_GameplayControls_Move;
    public struct GameplayControlsActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_GameplayControls_Jump;
        public InputAction @Crouch => m_Wrapper.m_GameplayControls_Crouch;
        public InputAction @Move => m_Wrapper.m_GameplayControls_Move;
        public InputActionMap Get() { return m_Wrapper.m_GameplayControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayControlsActions instance)
        {
            if (m_Wrapper.m_GameplayControlsActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnCrouch;
                @Move.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_GameplayControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public GameplayControlsActions @GameplayControls => new GameplayControlsActions(this);
    public interface IGameplayControlsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
