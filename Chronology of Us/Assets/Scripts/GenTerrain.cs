using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenTerrain : MonoBehaviour {

    public GameObject DirtTile;
    public GameObject GrassTile;
    public GameObject StoneTile;

    public int ChunkW;
    public float heightmultiplyer;
    public int heightadd;

    public float smoothness;

    int seed;

	void Start () {
        Generate();
        seed = Random.Range(-10000, 10000);
	} 
    
	
	public void Generate () {
        for (int i = 0; i < ChunkW; i++)
        {
            int h = Mathf.RoundToInt(Mathf.PerlinNoise(seed, i / smoothness) * heightmultiplyer) + heightadd;
        for (int j = 0; j < h; j++)
        {
        GameObject selectedTile;
                if (j < h -4)
                {
                    selectedTile = StoneTile;                   
                }
                else if (j < h - 1)
                {
                    selectedTile = DirtTile;
                }
                else
                {
                    selectedTile = GrassTile;
                }
                Instantiate(selectedTile, new Vector3(i, j), Quaternion.identity);
            }
        }
	}
}
