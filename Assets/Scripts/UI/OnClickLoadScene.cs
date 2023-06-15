using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;

public class OnClickLoadScene : OnClickEvent
{
	[SerializeField] private SceneToLoadContainerSO sceneContainer;
	[SerializeField] private AssetReference sceneToLoadReference;

    public override UnityAction Event() => () => sceneContainer.LoadScene(sceneToLoadReference);
}
