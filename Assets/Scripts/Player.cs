using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Projectile laserPrefab;

    public Rigidbody2D rigidbody { get; private set; }
    public Vector2 direction { get; private set; }

    public float speed = 5f;

    public GameObject losePanel;

    private bool _laserActive;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (direction != Vector2.zero)
        {
            rigidbody.AddForce(direction * speed);
        }
    }

    public void MoveRight()
    {
        direction = Vector2.right;
    }

    public void MoveLeft()
    {
        direction = Vector2.left;
    }

    public void DirectionReset()
    {
        direction = Vector2.zero;
    }

    public void Shoot()
    {
        if (!_laserActive)
        {
            AudioManager.instance.Play("Shoot");
            Projectile projectile = Instantiate(this.laserPrefab, this.transform.position, Quaternion.identity);
            projectile.destroyed += LaserDestroyed;
            _laserActive = true;
        }
    }

    private void LaserDestroyed()
    {
        _laserActive = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Invader")
            || other.gameObject.layer == LayerMask.NameToLayer("Missile"))
        {
            Time.timeScale = 0;
            losePanel.SetActive(true);
        }
    }
}
