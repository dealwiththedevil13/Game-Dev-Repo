using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public EnemySpawner[] ESSO;
    public float BetweenWaveDelayMain =3;
    float betweenWaveDelay;

    int currentESSO = 0;
    float spawnDelayMain = 0;
    float spawnDelay = 0;

    // Script from Dorei https://www.youtube.com/watch?v=uvIekOP07tU
    void Start()
    {
        betweenWaveDelay = BetweenWaveDelayMain;

        spawnDelayMain = ESSO[currentESSO].spawnDelay;
    }

    // Update is called once per frame
    void Update()
    {
        BetweenWaveDelay -= Time.deltaTime;

        if (betweenWaveDelay <= 0 && spawned < ESSO[currentESS0].spawnAmount)
        {
           Instantiate(ESS0[currentESS0].enemy, transform.position,Quaternion.identity);

           spawned++;

           spawnDelay = spawnDelayMain;

        }
        if (spawned <= ESS0[currentESS0].spawnAmount && currentESS0 +1 <ESSO.Length)
        {
            currentESS0++;

            spawned =0;
            spawnDelayMain = ESSO[currentESS0].spawnDelay;

            betweenWaveDelay = BetweenWaveDelayMain;
        }
    }
}
