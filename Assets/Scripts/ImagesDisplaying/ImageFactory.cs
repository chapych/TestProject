using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System.Threading.Tasks;
using UnityEngine.UI;

public class ImageFactory : MonoBehaviour 
{
	[SerializeField] private Image prefab;
	
	public async Task<Image> CreateAsync(int id)
	{
		Texture2D texture = await SpriteDownloader.GetTextureAsync(id);
		Sprite sprite = Sprite.Create(texture, new Rect(0,0, texture.width, texture.height), new Vector2(0,0), 1000);
		
		Image image = Instantiate(prefab);
		image.sprite = sprite;
		
		return image;
	}
}