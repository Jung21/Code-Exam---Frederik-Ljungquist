/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public delegate void StartTouchEvent(Vector2 position, float time);
    public event StartTouch OnStartTouch;
    public delegate void EndTouchEvent(Vector2 position, float time);
    public event StartTouch OnEndTouch;

    private TouchControls touchControls;

    private void Awake() {
        touchControls = new TouchControls();
    }

    private void OnEnable() {
        touchControls.Enable();

    }

    private void OnDisable() {
        touchControls.Disable();
    }
    private void Start () {
        touchControls.Touch.TouchPress.started += ctx => StartTouch(ctx);
        touchControls.Touch.TouchPress.canceled += ctx => EndTouch(ctx);
    }
    private void StartTouch(InputAction.CallbackContext context) {
        Debug.Log("Touch started" + touchControls.Touch.TouchPosition.ReadValue<Vector2>());
        if (OnStartTouch != null) OnStartTouch(touchControls.Touch.TouchPosition.ReadValue<Vector2>(), (float)context.startTime);
    }
    
    private void EndTouch(InputAction.CallbackContext context) {
        Debug.Log("Touch started" + touchControls.Touch.TouchPosition.ReadValue<Vector2>());
        if (OnEndTouch != null) OnStartTouch(touchControls.Touch.TouchPosition.ReadValue<Vector2>(), (float)context.time);

    }
}
*/