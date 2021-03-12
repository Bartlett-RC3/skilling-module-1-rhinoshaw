using System.Collections;
using UnityEngine;

public class Session_4_2_20_Sashank_GridGenerator : MonoBehaviour
{

	
	public int width = 5;
	public int height = 10;
	public GameObject gridElement;

	Ray ray;
	RaycastHit hit;
	


	// Use this for initialization
	void Start()
	{ 
	
		for (int y = 0; y < height; y++)
		{
			
			for (int x = 0; x < width; x++)
			{
				for (int z = 0; z < width; z++)
				{
					GameObject.Instantiate(gridElement, new Vector3(x,y,z),Quaternion.identity);	
				}
			}
		}

	}


    private void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit))
			{
				Destroy(hit.collider.gameObject);
				print("Destroyed prefab at " + Input.mousePosition);
			}
		}
	}
}
