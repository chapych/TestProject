using UnityEngine;

public class DDoL : MonoBehaviour //DontDestroyOnLoad
{
	static private DDoL instance;

	void Awake()
	{
		if(instance == null)
		{	
			instance = this;
			DontDestroyOnLoad(transform.root.gameObject);
		}
		else if(instance != this)
		{
			GetComponent<CellsUploading>().enabled = false;
			Destroy(transform.root.gameObject);
		}
	} 
}