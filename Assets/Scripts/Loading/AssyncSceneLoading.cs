using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class AssyncSceneLoading : MonoBehaviour
{
	private AsyncOperationHandle<SceneInstance> sceneHandle;
	[SerializeField] private int secondsOffset = 2;
	[SerializeField] private SliderValue slider;
	[SerializeField] private SceneToLoadContainerSO loadingSceneContainer;
	
	private void OnEnable() 
	{
		AssetReference sceneReference = loadingSceneContainer.nextSceneReference;
		sceneHandle = Addressables.LoadSceneAsync(sceneReference, LoadSceneMode.Single, false);
		
		sceneHandle.Completed+=OnSceneLoadedAsync;
	}
	
	private void OnDisable() 
	{
		sceneHandle.Completed-=OnSceneLoadedAsync;
	}
	
	private void Update()
	{
		var status = GetStatus(sceneHandle);
		float progress = GetProgress(status);
			
		slider.SetSliderValue(progress);
	}
	
	private async void OnSceneLoadedAsync(AsyncOperationHandle<SceneInstance> obj)
	{
		await WaitForAsync(secondsOffset);
		obj.Result.ActivateAsync();
	}
	
	private async Task WaitForAsync(int seconds) => await Task.Delay(seconds * 1000); //convert from ms to seconds
	
	private static float GetProgress(DownloadStatus status) => status.Percent;

	private static DownloadStatus GetStatus(AsyncOperationHandle<SceneInstance> sceneLoading)
	{
		return sceneLoading.GetDownloadStatus();
	}
}
