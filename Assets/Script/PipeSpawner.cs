using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public float SpawnRate = .1f;
    public float MaxYOffset = 1f;
    public Transform PipeSpawnPos;
    
    private float timer = float.MaxValue;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= SpawnRate)
        {
            DoStuff();
            timer = 0f;
        }
    }

    public void StartSpawning()
    {
        enabled = true;
    }

    void DoStuff()
    {
        float yOffset = Random.Range(-MaxYOffset, MaxYOffset);
        Vector3 spawnPosition = PipeSpawnPos.position + Vector3.up * yOffset;
        Instantiate(Pipe, spawnPosition, Quaternion.identity);
    }
}
