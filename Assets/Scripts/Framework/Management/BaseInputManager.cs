using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInputManager : MonoBehaviour {

    protected const float _inputDeadZone = .1f;

    public static EventHandler<MovementInputEventArgs> MovementInputEvent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float input = 0f;
        MovementInputEventArgs args = new MovementInputEventArgs();

        input = Input.GetAxis("Vertical");
        if (input > _inputDeadZone || input < -_inputDeadZone)
        {
            args.VerticalInput = input;
        }

        input = Input.GetAxis("Horizontal");
        if (input > _inputDeadZone || input < -_inputDeadZone)
        {
            args.HorizontalInput = input;
        }

        if (MovementInputEvent != null)
        {
            MovementInputEvent(this, args);
        }
	}

    private void OnDestroy()
    {
        MovementInputEvent = null;
    }
}

public class MovementInputEventArgs : EventArgs
{
    public float VerticalInput { get; set; }
    public float HorizontalInput { get; set; }

    public MovementInputEventArgs()
    {

    }

    public MovementInputEventArgs(float verticalInput, float horizontalInput)
    {
        VerticalInput = verticalInput;
        HorizontalInput = horizontalInput;
    }
}