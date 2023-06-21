using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subcriber : MonoBehaviour
{
	[SerializeField] private InputReaderSO inputReader;
	private Button button;
	void Start()
	{
		button = GetComponent<Button>();
		
		inputReader.ActionMapEnable();
		inputReader.OnGoBackEvent += OnGoBackHandle;
	}
	
	void OnGoBackHandle()
	{
		button.onClick?.Invoke();
	}
}
