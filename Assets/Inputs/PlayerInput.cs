//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Inputs/PlayerInput.inputactions
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

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""6cbe748c-19f9-4bcd-be03-d0b66fa32a52"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""bd91b400-19ed-44de-81ea-3960ce620006"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""34f03c66-4eab-48f4-a03f-d02cbe9d7490"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""411f4c91-48bc-4be3-a1b3-0b7aff9995bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8c8e490b-c610-4785-884f-f04217b23ca4"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce4290fa-0571-4329-9337-c5f5d55b3b05"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37c3af88-2b3e-4c0a-bb2f-5c15569095d7"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InventoryUI"",
            ""id"": ""a7a1434f-7946-4460-a364-3dda0e8eb0c4"",
            ""actions"": [
                {
                    ""name"": ""InventoryOnOff"",
                    ""type"": ""Button"",
                    ""id"": ""c52991c6-fbbe-48e5-bc21-7dd00511411a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CreateItem"",
                    ""type"": ""Button"",
                    ""id"": ""02cbef17-668d-4b25-bd34-e5e902eee182"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CreateEmptyItem"",
                    ""type"": ""Button"",
                    ""id"": ""bb6e3c47-790f-4b29-9ff6-ea40aaf23be4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ItemRotate"",
                    ""type"": ""Button"",
                    ""id"": ""db35361f-7c7b-4f19-9f52-977e1132bf55"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""5c197a82-c8b6-420f-bbc3-96ac95c6518b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""97fd76ac-c5bf-4934-a38b-8b3b18c70cbf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9b61024f-a2d9-4bc3-aa3e-64a962ce2b02"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""InventoryOnOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b60109b4-7b8a-46f9-8da3-6006fa645495"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CreateItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6986167-6109-4539-86d8-8a8c613f9bea"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""CreateEmptyItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""907c7d42-a41a-4993-b958-1ef40f82bb92"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""ItemRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62354a6e-7531-466d-b6e5-f4ba18fa42ab"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d5d0e62-8048-4433-acd3-d57c9b94c5c4"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameManager"",
            ""id"": ""d45ce9ac-a597-4f70-b106-9ef93654099b"",
            ""actions"": [
                {
                    ""name"": ""ItemNameOnOff"",
                    ""type"": ""Button"",
                    ""id"": ""d06366f9-4b75-4fda-b905-8617f9807fd4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""02e0b7f4-fdfb-40ab-8e42-c4c8636f444f"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""ItemNameOnOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_LeftClick = m_Player.FindAction("LeftClick", throwIfNotFound: true);
        m_Player_RightClick = m_Player.FindAction("RightClick", throwIfNotFound: true);
        // InventoryUI
        m_InventoryUI = asset.FindActionMap("InventoryUI", throwIfNotFound: true);
        m_InventoryUI_InventoryOnOff = m_InventoryUI.FindAction("InventoryOnOff", throwIfNotFound: true);
        m_InventoryUI_CreateItem = m_InventoryUI.FindAction("CreateItem", throwIfNotFound: true);
        m_InventoryUI_CreateEmptyItem = m_InventoryUI.FindAction("CreateEmptyItem", throwIfNotFound: true);
        m_InventoryUI_ItemRotate = m_InventoryUI.FindAction("ItemRotate", throwIfNotFound: true);
        m_InventoryUI_LeftClick = m_InventoryUI.FindAction("LeftClick", throwIfNotFound: true);
        m_InventoryUI_RightClick = m_InventoryUI.FindAction("RightClick", throwIfNotFound: true);
        // GameManager
        m_GameManager = asset.FindActionMap("GameManager", throwIfNotFound: true);
        m_GameManager_ItemNameOnOff = m_GameManager.FindAction("ItemNameOnOff", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_LeftClick;
    private readonly InputAction m_Player_RightClick;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @LeftClick => m_Wrapper.m_Player_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_Player_RightClick;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @LeftClick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftClick;
                @RightClick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightClick;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // InventoryUI
    private readonly InputActionMap m_InventoryUI;
    private IInventoryUIActions m_InventoryUIActionsCallbackInterface;
    private readonly InputAction m_InventoryUI_InventoryOnOff;
    private readonly InputAction m_InventoryUI_CreateItem;
    private readonly InputAction m_InventoryUI_CreateEmptyItem;
    private readonly InputAction m_InventoryUI_ItemRotate;
    private readonly InputAction m_InventoryUI_LeftClick;
    private readonly InputAction m_InventoryUI_RightClick;
    public struct InventoryUIActions
    {
        private @PlayerInput m_Wrapper;
        public InventoryUIActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @InventoryOnOff => m_Wrapper.m_InventoryUI_InventoryOnOff;
        public InputAction @CreateItem => m_Wrapper.m_InventoryUI_CreateItem;
        public InputAction @CreateEmptyItem => m_Wrapper.m_InventoryUI_CreateEmptyItem;
        public InputAction @ItemRotate => m_Wrapper.m_InventoryUI_ItemRotate;
        public InputAction @LeftClick => m_Wrapper.m_InventoryUI_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_InventoryUI_RightClick;
        public InputActionMap Get() { return m_Wrapper.m_InventoryUI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryUIActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryUIActions instance)
        {
            if (m_Wrapper.m_InventoryUIActionsCallbackInterface != null)
            {
                @InventoryOnOff.started -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnInventoryOnOff;
                @InventoryOnOff.performed -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnInventoryOnOff;
                @InventoryOnOff.canceled -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnInventoryOnOff;
                @CreateItem.started -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnCreateItem;
                @CreateItem.performed -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnCreateItem;
                @CreateItem.canceled -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnCreateItem;
                @CreateEmptyItem.started -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnCreateEmptyItem;
                @CreateEmptyItem.performed -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnCreateEmptyItem;
                @CreateEmptyItem.canceled -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnCreateEmptyItem;
                @ItemRotate.started -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnItemRotate;
                @ItemRotate.performed -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnItemRotate;
                @ItemRotate.canceled -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnItemRotate;
                @LeftClick.started -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnLeftClick;
                @RightClick.started -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_InventoryUIActionsCallbackInterface.OnRightClick;
            }
            m_Wrapper.m_InventoryUIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @InventoryOnOff.started += instance.OnInventoryOnOff;
                @InventoryOnOff.performed += instance.OnInventoryOnOff;
                @InventoryOnOff.canceled += instance.OnInventoryOnOff;
                @CreateItem.started += instance.OnCreateItem;
                @CreateItem.performed += instance.OnCreateItem;
                @CreateItem.canceled += instance.OnCreateItem;
                @CreateEmptyItem.started += instance.OnCreateEmptyItem;
                @CreateEmptyItem.performed += instance.OnCreateEmptyItem;
                @CreateEmptyItem.canceled += instance.OnCreateEmptyItem;
                @ItemRotate.started += instance.OnItemRotate;
                @ItemRotate.performed += instance.OnItemRotate;
                @ItemRotate.canceled += instance.OnItemRotate;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
            }
        }
    }
    public InventoryUIActions @InventoryUI => new InventoryUIActions(this);

    // GameManager
    private readonly InputActionMap m_GameManager;
    private IGameManagerActions m_GameManagerActionsCallbackInterface;
    private readonly InputAction m_GameManager_ItemNameOnOff;
    public struct GameManagerActions
    {
        private @PlayerInput m_Wrapper;
        public GameManagerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ItemNameOnOff => m_Wrapper.m_GameManager_ItemNameOnOff;
        public InputActionMap Get() { return m_Wrapper.m_GameManager; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameManagerActions set) { return set.Get(); }
        public void SetCallbacks(IGameManagerActions instance)
        {
            if (m_Wrapper.m_GameManagerActionsCallbackInterface != null)
            {
                @ItemNameOnOff.started -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnItemNameOnOff;
                @ItemNameOnOff.performed -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnItemNameOnOff;
                @ItemNameOnOff.canceled -= m_Wrapper.m_GameManagerActionsCallbackInterface.OnItemNameOnOff;
            }
            m_Wrapper.m_GameManagerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ItemNameOnOff.started += instance.OnItemNameOnOff;
                @ItemNameOnOff.performed += instance.OnItemNameOnOff;
                @ItemNameOnOff.canceled += instance.OnItemNameOnOff;
            }
        }
    }
    public GameManagerActions @GameManager => new GameManagerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
    }
    public interface IInventoryUIActions
    {
        void OnInventoryOnOff(InputAction.CallbackContext context);
        void OnCreateItem(InputAction.CallbackContext context);
        void OnCreateEmptyItem(InputAction.CallbackContext context);
        void OnItemRotate(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
    }
    public interface IGameManagerActions
    {
        void OnItemNameOnOff(InputAction.CallbackContext context);
    }
}
