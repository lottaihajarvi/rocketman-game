using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{

    public GameObject platform;
    public float Width = 2f;
    public int platformQuantity = 100;

    // Start is called before the first frame update
    void Start()
    {

        Vector3 spawnPos = new Vector3();

        for (int i = 0; i < platformQuantity; i++)
        {
            spawnPos.y += Random.value;
            spawnPos.x = Random.Range(-Width, Width);
            Instantiate(platform, spawnPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
