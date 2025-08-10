using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class spawner : MonoBehaviour
{
     [Header("Target Prefab")]
    public GameObject targetPrefab;

    [Header("Spawn Settings")]
    public int maxTargets = 5;           // How many targets exist at once
    public float spawnInterval = 1f;     // Time between spawns

    [Header("Spawn Area")]
    public Vector3 minPosition;          // Bottom-left corner of spawn area
    public Vector3 maxPosition;

    public static bool start = false;

    private float gameTimer;

    public static float wavetimer;      // Top-right corner of spawn area

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (playercontroller.wavestart)
        {


            wavetimer += Time.deltaTime;
            gameTimer += Time.deltaTime;
            if (gameTimer >= .8f)
            {
                gameTimer = 0f;
                SpawnTarget();
                
            }

            if (wavetimer >= 25f)
            {
                playercontroller.wavestart = false;wavetimer = 0f;
                if (playercontroller.score > playercontroller.bestscore)
                {
                    playercontroller.bestscore = playercontroller.score;
                }
                
                playercontroller.score = 0;
            }


        }



        
    }
    void SpawnTarget()
    {
        
        float x = Random.Range(minPosition.x, maxPosition.x);
        float y = Random.Range(minPosition.y, maxPosition.y);
        float z = Random.Range(minPosition.z, maxPosition.z);

        Vector3 spawnPos = new Vector3(x, y, z);
        Instantiate(targetPrefab, spawnPos, Quaternion.identity);
    }
}
