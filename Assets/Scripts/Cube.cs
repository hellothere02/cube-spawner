using UnityEngine;

public class Cube : MonoBehaviour
{
   public float Speed { get; set; }
   public float Distance { get; set; }

    private void Start()
    {
        Destroy(this.gameObject, Distance / Speed);  
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(Distance, transform.position.y, transform.position.z), Time.deltaTime * Speed);
    }
}
