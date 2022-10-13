using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private InputField time;
    [SerializeField] private InputField speed;
    [SerializeField] private InputField distance;

     private Spawner spawner;

    private void Start()
    {
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
    }

    public void SetTimeToSpawn()
    {
        float timeToSpawn;

        if (float.TryParse(time.text, out timeToSpawn))
        {
            spawner.TimeToSpawn = timeToSpawn;
        }
        else
        {
            spawner.TimeToSpawn = 1;
        }
    }

    public void SetSpeed()
    {
        float CubeSpeed;

        if (float.TryParse(speed.text, out CubeSpeed))
        {
            spawner.Speed = CubeSpeed;
        }
        else
        {
            spawner.Speed = 1;
        }
    }

    public void SetDistance()
    {
        float Cubedistance;

        if (float.TryParse(distance.text, out Cubedistance))
        {
            spawner.Distance = Cubedistance;
        }
        else
        {
            spawner.Distance = 1;
        }
    }
}
