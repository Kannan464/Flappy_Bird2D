using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling sharedinstance;
	public List<GameObject> poolObject;
	public GameObject objectPool;
	public int amountPool;
	private void Awake()
	{
		sharedinstance = this;
	}

	void Start()
	{
		poolObject = new List<GameObject>();
		GameObject pipe;


		for (int i = 0; i < amountPool; i++)
		{
			pipe = Instantiate(objectPool);
			pipe.transform.position = new Vector2(50, 0);
			pipe.SetActive(false);

			poolObject.Add(pipe);
		}
	}

	public GameObject GetPooledObject()
	{
		for (int i = 0; i < amountPool; i++)
		{
			if (!poolObject[i].activeSelf)
			{
				return poolObject[i];
			}
		}
		return null;
	}
}
