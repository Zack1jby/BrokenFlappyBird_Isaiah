using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Pipe;
    [SerializeField] private float SpawnRate = .1f;
    [SerializeField] private float MaxYOffset = 1f;
    [SerializeField] private Transform PipeSpawnPos;
    
    private float timer = float.MaxValue;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= SpawnRate)
        {
            SpawnPipes();
            timer = 0f;
        }
    }

    public void StartSpawning()
    {
        enabled = true;
    }

    private void SpawnPipes()
    {
        float yOffset = Random.Range(-MaxYOffset, MaxYOffset);
        Vector3 spawnPosition = PipeSpawnPos.position + Vector3.up * yOffset;
        Instantiate(Pipe, spawnPosition, Quaternion.identity);
    }
}
