using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject cubePref;
    private float timeToSpawn;
    public float TimeToSpawn { get => timeToSpawn; set => timeToSpawn = value; }
    public float Speed { get; set; }
    public float Distance { get; set; }


    private void Start()
    {
        timeToSpawn = 10;
        StartCoroutine("Spawn");
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(timeToSpawn);
        GameObject GO = Instantiate(cubePref, transform.position, Quaternion.identity);
        GO.GetComponent<Cube>().Distance = Distance;
        GO.GetComponent<Cube>().Speed = Speed;
        StartCoroutine("Spawn");
    }
}
