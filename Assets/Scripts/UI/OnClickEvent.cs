using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class OnClickEvent : MonoBehaviour
{
	protected Button button;
	public abstract UnityAction Event();
	void Start()
	{
		button = GetComponent<Button>();

		button.onClick.AddListener(Event());
	}
}