using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

public class OnClickLoadImage : OnClickEvent
{
	[SerializeField] private ImageToLoadContainerSO imageContainer;

	public override UnityAction Event()
	{
		Image image = button.GetComponent<Image>();
		return () => imageContainer.Set(image);
	}
}
