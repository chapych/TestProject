using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

public partial class OnClickEnableDisable : OnClickEvent
{
	[SerializeField] private CanvasContainerSO container;
	
	public Condition condition;
	public override UnityAction Event()
	{
		return () => MethodAction();
	}
	private void MethodAction()
	{
		switch(condition)
		{
			case Condition.ToDisable:
			{
				var canvasTransform = transform.root;
				Canvas canvas = canvasTransform.GetComponent<Canvas>();
				CanvasGroup group = canvasTransform.GetComponent<CanvasGroup>();
		
				group.alpha = 0;
				group.interactable = false;
		
				container.Set(canvas);
				break;
			}
			case Condition.ToEnable:
			{
				Canvas canvas = container.Canvas;
				CanvasGroup group = canvas.GetComponent<CanvasGroup>();
		
				group.alpha = 1;
				group.interactable = true;
		
				container.Set(null);
				break;
			}
		}
		
		
		
	}
}
