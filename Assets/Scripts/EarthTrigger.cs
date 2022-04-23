using UnityEngine;
using UnityEngine.SceneManagement;

public class EarthTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Earth")
        {
            SceneManager.LoadScene(2);
        }
    }
}
