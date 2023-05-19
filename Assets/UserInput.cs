using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserInput : MonoBehaviour
{

    public static UserInput instance;

    public Vector2 MoveInput { get; private set; }

    public bool MenuOpenCloseImput { get; private set; }


    private PlayerInput _playerInput;

    private InputAction _moveAction;
    private InputAction _menuOpenCloseAction;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        _playerInput = GetComponent<PlayerInput>();

        SetupInputActions();
    }

    void Update()
    {
        UpdateInputs();
    }

    private void SetupInputActions()
    {
        _moveAction = _playerInput.actions["Move"];
        _menuOpenCloseAction = _playerInput.actions["MenuOpenClose"];
    }

    private void UpdateInputs()
    {
        MoveInput = _moveAction.ReadValue<Vector2>();
        MenuOpenCloseImput = _menuOpenCloseAction.WasPressedThisFrame();
    }
}
