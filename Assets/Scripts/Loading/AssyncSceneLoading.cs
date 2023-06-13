using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class AssyncSceneLoading : MonoBehaviour
{
	[SerializeField] private float secondsOffset = 2;
	[SerializeField] private SliderValue slider;
	[SerializeField] private SceneToLoadContainerSO loadingManager;
	private void Start()
	{
		StartCoroutine(SceneLoading(loadingManager.sceneToLoadReference));
	}
	private IEnumerator SceneLoading(AssetReference sceneReference)
	{
		var sceneLoading = Addressables.LoadSceneAsync(sceneReference, LoadSceneMode.Single, false);
		var status = GetStatus(sceneLoading);
		
		while(!status.IsDone)
		{
			status = GetStatus(sceneLoading);
			float progress = GetProgress(status);
			
			slider.SetSliderValue(progress);

			yield return null;
		}
		yield return new WaitForSeconds(secondsOffset);
		sceneLoading.Result.ActivateAsync();
	}

	private static float GetProgress(DownloadStatus status) => status.Percent;

	private static DownloadStatus GetStatus(AsyncOperationHandle<SceneInstance> sceneLoading)
	{
		return sceneLoading.GetDownloadStatus();
	}
}
