using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawning : MonoBehaviour
{
    public List<GameObject> ObjectsToSpawn = new List<GameObject>(3);
    private List<float> XPosSpawn = new List<float> { -0.75f, -0.25f, 0.25f, 0.75f};
    private float YSpawnPos = 1f;
    private float ZSpawnPos = 40f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", 1, 1f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void InstantiateObjects()
    {
        GameObject ObjToSpawn = ObjectsToSpawn[Random.Range(0,ObjectsToSpawn.Count)];        
        float RandomX = XPosSpawn[Random.Range(0, XPosSpawn.Count)];
        Vector3 SpawnPos = new Vector3(RandomX, YSpawnPos, ZSpawnPos);
        Instantiate(ObjToSpawn, SpawnPos, Quaternion.identity);
    }
}
