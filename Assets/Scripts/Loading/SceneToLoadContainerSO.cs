using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Scene To Load Container", menuName = "ScriptableObjects/Scene To Load Container")]
public class SceneToLoadContainerSO : ScriptableObject
{
	[SerializeField] private AssetReference loadingScreenReference;
	public AssetReference nextSceneReference { get; private set; }
	
	public void Set(AssetReference nextSceneReference) 
	{
		this.nextSceneReference = nextSceneReference;
	}
	
	public void Load()
	{
		Addressables.LoadSceneAsync(loadingScreenReference);
	}
}
