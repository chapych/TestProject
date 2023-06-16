using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;

public class OnClickLoadScene : OnClickEvent
{
	[SerializeField] private SceneToLoadContainerSO container;
	[SerializeField] private AssetReference sceneToLoadReference;

	public override UnityAction Event() => () => SetAndLoad(sceneToLoadReference);
	
	private void SetAndLoad(AssetReference sceneToLoadReference)
	{
		container.Set(sceneToLoadReference);
		container.Load();
	}
}
