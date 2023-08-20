using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PlayerInputActions playerInputActions;
    private void Awake()
    {
        // PlayerInputActions is the class i have generated in the asset folder
           playerInputActions = new PlayerInputActions();
        
        // by defalut the action maps are desabled so i have to activate the right one
           playerInputActions.Player.Enable();
    }
    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        Debug.Log(inputVector);
        return inputVector;
    }
}
