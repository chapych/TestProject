using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System.Threading.Tasks;

public class SpriteDownloader
{
	static private string storageUrl = "http://data.ikppbb.com/test-task-unity-data/pics/";
	static private int maxId = 66;
	static public async Task<Texture2D> GetTextureAsync(int id)
	{
		if(id>maxId) 
		{

			Debug.Log("Index Out Of Bounds");
			return null;
		}
		
		string imageUrl = storageUrl + id + ".jpg";
		
		using UnityWebRequest www = UnityWebRequestTexture.GetTexture(imageUrl);
		var request = www.SendWebRequest();
		
		while(!request.isDone)
			await Task.Yield();
			
		Texture2D myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture;
		return myTexture;
	}
}