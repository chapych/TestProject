using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.UI.Button;

[CreateAssetMenu(menuName = "InputReader")]
public class InputReaderSO : ScriptableObject, Controls.INavigationActions
{
	private Controls controls;
	public event Action OnGoBackEvent;
	
	private void OnEnable()
	{
		if (controls == null)
		{
			controls = new Controls();
			controls.Navigation.SetCallbacks(this);
			ActionMapEnable();
		}
	}
	
	public void ActionMapEnable()
	{
		controls.Navigation.Enable();
	}
	public void OnGoBack(InputAction.CallbackContext context)
	{
		if(context.started)
			OnGoBackEvent?.Invoke();
	}
}
