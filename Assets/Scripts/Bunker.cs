using UnityEngine;

public class Bunker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Invader")
        {
            this.gameObject.SetActive(false);
        }
    }
}
