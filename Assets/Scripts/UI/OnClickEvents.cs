using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public class OnClickEvents : MonoBehaviour
{
	private Button button;
	[SerializeField] private SceneToLoadContainerSO sceneContainer;
	[SerializeField] private AssetReference sceneToLoadReference;
	void Start()
	{
		button= GetComponent<Button>();
		
		button.onClick.AddListener(()=>sceneContainer.LoadScene(sceneToLoadReference));
	}
}
