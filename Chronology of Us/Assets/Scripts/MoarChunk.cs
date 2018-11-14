using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoarChunk : MonoBehaviour {

    public GameObject chunk;

    public int ChunkNumber;

    

	void Start () {
        for (int i = 0; i < ChunkNumber; i++)
        {
            Instantiate(chunk, new Vector3(75 * i, 0), Quaternion.identity);
        }
	}
	

	void Update () {
		
	}
}
