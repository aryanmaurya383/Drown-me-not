using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] terrainPrefabs;
    public float xSpawn=10;
    public float terrainLength=30;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTerrain(0);
        SpawnTerrain(1);
        SpawnTerrain(0);
        SpawnTerrain(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTerrain(int terrainIndex)
    {
        Instantiate(terrainPrefabs[terrainIndex], transform.forward * xSpawn, transform.rotation);
        xSpawn += terrainLength;
    }
}
