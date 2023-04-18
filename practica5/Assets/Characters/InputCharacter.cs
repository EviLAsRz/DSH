//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Characters/InputCharacter.inputactions
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

public partial class @InputCharacter : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputCharacter()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputCharacter"",
    ""maps"": [
        {
            ""name"": ""actionMovimiento"",
            ""id"": ""8d018ef1-8b4b-4fcd-ba10-f138cc743d81"",
            ""actions"": [
                {
                    ""name"": ""Moverse"",
                    ""type"": ""Value"",
                    ""id"": ""34507680-993b-4dba-ab47-9b4d3350858f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Correr"",
                    ""type"": ""Button"",
                    ""id"": ""3846c8c3-653d-469d-8bf2-b0339319ba4e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""db3ca688-99b4-4766-94d6-8126736d58d9"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Moverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""420cfda5-9c63-48ff-88fb-4a84cddfcebc"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Correr"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // actionMovimiento
        m_actionMovimiento = asset.FindActionMap("actionMovimiento", throwIfNotFound: true);
        m_actionMovimiento_Moverse = m_actionMovimiento.FindAction("Moverse", throwIfNotFound: true);
        m_actionMovimiento_Correr = m_actionMovimiento.FindAction("Correr", throwIfNotFound: true);
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

    // actionMovimiento
    private readonly InputActionMap m_actionMovimiento;
    private IActionMovimientoActions m_ActionMovimientoActionsCallbackInterface;
    private readonly InputAction m_actionMovimiento_Moverse;
    private readonly InputAction m_actionMovimiento_Correr;
    public struct ActionMovimientoActions
    {
        private @InputCharacter m_Wrapper;
        public ActionMovimientoActions(@InputCharacter wrapper) { m_Wrapper = wrapper; }
        public InputAction @Moverse => m_Wrapper.m_actionMovimiento_Moverse;
        public InputAction @Correr => m_Wrapper.m_actionMovimiento_Correr;
        public InputActionMap Get() { return m_Wrapper.m_actionMovimiento; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionMovimientoActions set) { return set.Get(); }
        public void SetCallbacks(IActionMovimientoActions instance)
        {
            if (m_Wrapper.m_ActionMovimientoActionsCallbackInterface != null)
            {
                @Moverse.started -= m_Wrapper.m_ActionMovimientoActionsCallbackInterface.OnMoverse;
                @Moverse.performed -= m_Wrapper.m_ActionMovimientoActionsCallbackInterface.OnMoverse;
                @Moverse.canceled -= m_Wrapper.m_ActionMovimientoActionsCallbackInterface.OnMoverse;
                @Correr.started -= m_Wrapper.m_ActionMovimientoActionsCallbackInterface.OnCorrer;
                @Correr.performed -= m_Wrapper.m_ActionMovimientoActionsCallbackInterface.OnCorrer;
                @Correr.canceled -= m_Wrapper.m_ActionMovimientoActionsCallbackInterface.OnCorrer;
            }
            m_Wrapper.m_ActionMovimientoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Moverse.started += instance.OnMoverse;
                @Moverse.performed += instance.OnMoverse;
                @Moverse.canceled += instance.OnMoverse;
                @Correr.started += instance.OnCorrer;
                @Correr.performed += instance.OnCorrer;
                @Correr.canceled += instance.OnCorrer;
            }
        }
    }
    public ActionMovimientoActions @actionMovimiento => new ActionMovimientoActions(this);
    public interface IActionMovimientoActions
    {
        void OnMoverse(InputAction.CallbackContext context);
        void OnCorrer(InputAction.CallbackContext context);
    }
}