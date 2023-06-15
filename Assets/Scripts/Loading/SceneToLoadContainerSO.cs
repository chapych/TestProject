using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Scene To Load Container", menuName = "ScriptableObjects/Scene To Load Container")]
public class SceneToLoadContainerSO : ScriptableObject
{
	[SerializeField] private AssetReference loadingScreenSceneReference;
	public AssetReference sceneToLoadReference { get; private set; }
	
	public void LoadScene(AssetReference sceneReference) //set the scene and load loading screen
	{
		sceneToLoadReference = sceneReference;
		Addressables.LoadSceneAsync(loadingScreenSceneReference);
	}
}
